---
Title: Working in the open
tags:
  - Income Management
RedirectFrom:
  - 20190522
---
Yesterday we held our first *external* show and tell session as a product team, demonstrating the features of our in-house developed Income Management System.

I've [blogged about our Income Management System before](/20190102) and how thrilled we are that we took the plunge and invested our energies into creating it. It's a fantastic solution that we're thrilled with and we're always happy to talk about it and sing it's praises.

We're used to running show and tell sessions around our developments - we've been following Scrum practices for a couple of years now - but those have always been with internal colleagues and so presenting externally yesterday was very different. As a remote Google Hangout, we couldn't see the people we were presenting to once we'd gotten started and that made it difficult to gauge the "room" and to tailor what we were saying. In hindsight, we ought to have had a second screen on standby to hold the main Hangout window, so there's a lesson learned.

Still, I think it went well and the feedback afterwards was positive. There were a good number of questions that I think we were able to answer and we've agreed to share [a video of the event on YouTube](https://www.youtube.com/watch?v=Mh4wWuZc1ZA). We'll also be creating a new [income-management channel](https://localgovdigital.slack.com/messages/CJW65RNAY/) on the [LocalGov Digital Slack workspace](https://localgovdigital.slack.com/) to hold further discussions as per a suggestion from Phil Rumens at West Berkshire. I'd like to use that channel to take more questions and to follow up in more detail - perhaps sharing some screenshots of the functionality we have now and how different scenarios can be played out in the system.

Primarily though yesterday was a fantastic opportunity to open our doors in Barnsley! The first step towards working in the open as per our commitment when we co-published the [Local Digital Declaration](https://localdigital.gov.uk/declaration/). What we're doing here is taking one of our flagship products and sharing it - firstly we did that with the Gov.UK Pay Product Team back in March and after a wonderful response from them, now we've done it with other local authorities.

Our original on-site demo to the Gov.UK Pay Product Team came off the back of my previous blog post fortuitously landing in front of them at just the right time. [North East Lincolnshire Council](https://www.nelincs.gov.uk/) had succesfully bid for monies from the Local Digital Fund and were running a Discovery project with them, the Publica Group (Cotswold DC, West Oxfordshire DC and Forest of Dean DC), Allerdale Council and Oxford City Council around the use of [GOV.UK Pay as a viable alternative e-payment provider](https://localdigital.gov.uk/funding/north-east-lincolnshire-council/). 

My understanding is that while carrying out their research they identified a common difficulty across local government in managing the income that a product like [Gov.UK Pay](https://www.payments.service.gov.uk/) enables. After a few phone calls, a visit to Barnsley and some email discussions the output from the Discovery piece recommended that an Alpha project go ahead to see how our system might help resolve that - and so here we are today.

Ultimately we'd love to see our system operating in a multi-tenanted Software as a Service capacity on the [Gov.UK Platform as a Service](https://www.cloud.service.gov.uk/) offer, with the code available open-source and perhaps a cohort of local government colleagues holding responsibility for accepting/rejecting pull requests into its core. There's a lot of work to be done between here and there and that's where a funded Alpha project would undoubtedly help.

I do hope that happens and in the meantime we'll continue to release new iterations of the product. We have 3 gaps to fill with regards to meeting the [12-factors](https://12factor.net/) that Gov.UK PaaS requires and we'd like to consider using an alternative database to Microsoft SQL Server. The system is currently built in .NET but not Core as that wasn't available at the time we started - we see benefit migrating to that.

Lots to consider and very exciting times.