---
Title: Setting up my SX1276 LoRaWAN board
redirect_from:
  - /20171223
---

Having taken delivery of my new board which I ordered from [AliExpress](https://www.aliexpress.com/item/868MHz-915MHz-SX1276-ESP32-LoRa-0-96-Inch-Blue-OLED-Display-Bluetooth-WIFI-Lora-Kit-32/32840258107.html), I was keen to get started on making something with it.

I wasn't quite sure what I was going to make yet, but I eventually settled on the idea of a simple 'station' to monitor ambient noise and ambient light levels in my back garden. Not rocket science you might think, but it would give me an opportunity to use the board, The Things Network, Cayenne, a 3.7V Li Ion battery that I had lying around and a spare microphone and light sensors I had from my Arduino Starter Kit that I bought last year.

So, the first thing I need to do was make sure my computer could communicate with my new board so that I could eventually program it to do my bidding.

The board is designed and produced by Heltec Automation and is essentially an ESP32 WiFi chip with an SX1276 Lora Transceiver and 0.9inch blue OLED attached. It's also Bluetooth/BLE capable but I wasn't intending to use those just yet. It also includes a built-in Li Ion charging circuit which could come in handy and a CP2102 USB to Serial chip which allows my computer to talk to it directly via USB.

You can view the manufacturers catalogue page for the [full specification](http://heltec.diytrade.com/sdp/2044581/4/pd-6785993/12013554-0/ESP32_Development_board_Lora_Transceiver_SX1278_43.html) but note this is for their version with the SX127*8* LoRa Transciever attached which runs on 433Mhz only. The 1276 runs on 868Mhz which is what I need to connect to The Things Network here in Europe.

So, having plugged the board into my computer via USB, making sure to use a data cable and not just one that transfers power (this always catches me out!), I immediately found that my Arduino IDE didn't recognise it. There's no board available in my Boards menu and no Port avaialble to select either.

After a little Googling about the lack of a Board option, I found out that the ESP32 is a 32BIT WiFi board made by a company called Espressif. They have a github page and specific software for integration with the Arduino IDE that you can simply 'install'. I followed [the instructions](https://github.com/espressif/arduino-esp32/blob/master/docs/arduino-ide/mac.md) there and after restarting the IDE, hey presto - I had a board on my boards menu called Heltec_WiFi_Lora_32.

As for the port, I knew the board was using CP2102 and so it was most likely that my computer just needed to know what that was. So, after a little more Googling I discovered [Silabs USB to Uart Bridge VCP Drivers](https://www.silabs.com/products/development-tools/software/usb-to-uart-bridge-vcp-drivers) and downloaded them - all search roads seemed to end there so it seemed like the right choice. I installed them, restarted the IDE again and I had a new port listed as /dev/cu.SLAB_USBtoUART.

I set my frequency to 80Mhz on the understanding the board works at 240Mhz from the product catalogue detail (80Mhz was the highest I could choose) and I set the upload speed to 921600 which is around 0.88Mbits. The catalogue told me the board can take up to 1Mbit data transfers and this was the closest baud rate beneath that.

So, now we we're cooking on gas - the IDE was configured and all I had to do was upload some code to the board to see what I could make it do.

Knowing that I wanted to upload readings from my sensors (once I'd soldered them in) to The Things Network, I started by adding their library to my IDE (Sketch > Include Library > Manage Libraries) - version 2.5.6 at the time of writing. I then looked for their examples (File > Examples > TheThingsNetwork) and found one called LightSensor - perfect - and so I started to tinker with that.

Trying to compile it though gave me huge problems in that the code needed an implementation of two Serial ports and I only had 1 on this board. I could get around that with a software based Serial approach but everything I read warned me against that, and even trying to get it working had me losing my mind.

So, a little more research later I came across a library on GitHub that had been specifically designed to work with the The Things Network.

I downloaded and implemented that and fired up the ttn-oota example to take a look at how it worked.



To get my display working I had to download the SSD1306 library from https://github.com/squix78/esp8266-oled-ssd1306 and use the IDE menus to import library from ZIP. I could then reference this using #include <SSD1306Wire.h>