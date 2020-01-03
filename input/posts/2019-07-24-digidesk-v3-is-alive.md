---
Title: DigiDesk v3 is alive!
Tags: 
  - DigiDesk
  - Innovation Group
RedirectFrom:
  - 20190724
---
Today we've completed the breadboard development of DigiDesk v3 and it works an absolute treat!

[![Desk Occupancy Monitor v3.0](https://img.youtube.com/vi/EPXpI4ZLL34/0.jpg)](https://www.youtube.com/watch?v=EPXpI4ZLL34)

We've set up a demo desk in our maker space at the Barnsley DMC with a keyboard, mouse, screen, desk lamp, and printer. Ideally we'd have had a second screen and a dock rather than a lamp and a printer but this represents a similar level of power usage to our typical office desk setup, so it's all good.

A quick scan of any council ID badge instructs the device to communicate with a central dashboard over Wi-Fi, register the desk as occupied and turn on the power to it. You'll see in the video that the screen, printer and lamp all kick into life. A second quick scan of a badge instructs the device to "de-register" the desk and switch off the power. You'll see that everything switches off almost immediately. 

There is a bit of a lag with it at the moment which is due to the time it takes the device to register/de-register the desk, then re-check the status of the desk. It rechecks to make sure the registration has succeeded, as opposed to just assuming it has. If it were to assume it had when it actually hadn't, the device would end up out of sync and it would end up switching power off when it should be on and vice versa. We plan to speed that up though.

While we've been working on this, as I mentioned in [my last DigiDesk post](/20190626), we've also been considering the commercials for it. Branding is underway. We've been speaking with various companies who can create some casing and circuit boards for it to help us bring it to market quickly when we've moved it forward a little further.

Exciting stuff and not bad for only 2 working days worth of effort since that last post!