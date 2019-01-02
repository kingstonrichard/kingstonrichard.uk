---
layout: post
title: "We built our own Income Management solution"
date: 2019-01-02
categories: work
intro: This is the story of why we chose to develop our own critical software solution, over renewing an incumbent contract
---
Let me start this post by briefly explaining the function of income management within local authorities. It presents a significant challenge in terms of logistics at the very least. Monies continually arrive from a variety of different sources (citizens, businesses, partners, etc.) for many different reasons (taxes, fines, services delivered, etc.) via many different methods (cash, cheque, card, elecontric, etc.) and through many different channels (direct debit, standing order, bank transfer, automated telephone service, etc.). Digital transactions happen quickly. Physical cash transactions take a little longer. In any given hour on any given day there are potentially hundreds if not thousands of incoming transactions that need to be taken care of.

Every penny of every transaction must be captured, verified, validated to make sure we understand where its come from and why its here. Once approved they must be routed off to the right internal account(s) to balance our creditor records and to update other system records that we hold. Mr Smith has paid his parking fine and so we should now cancel any automatic reminders we were due to issue to him. It must all happen quickly, efficiently and correctly! Preferably, it should be automated. It's a huge coordination effort. The need for (and cost of) human effort should be minimised, as should any opportunity for processing errors to sneak in at points along the way. As a single account can see thousands of transactions a day, even the smallest error carries the potential to cause big issues.

And so as you might expect, software has a huge part to play in this 24x7x365 operation. During my most recent 10 years with Barnsley Council, colleagues had been orchestrating this choreographed dance very well, with the support of a suite of software products from one of the well-known major suppliers to local government. My technical team had configured that suite into a streamlined work of art. They'd worked closely with our internal departments to define it's various rules of validation, it's steps of automation, the required channels that it made avaialble and they'd configured the whole thing to within an inch of it's life. The situation was good.

Good, but not perfect! It wasn't an easy task keeping on top of it all. We know that we weren't always using the suite to the best of its abilities. We weren't always squeezing the most out of it's potential. But even so, our experience of it was that the individual products in the suite didn’t necessarily play well together and that meant our staff had lots of manual input to do despite our technical efforts. It was often necessary to double key transactional data over several screens. Interfaces were unfriendly, seemingly designed c1995 and staff had to absolutely know their way around the suite in detail to use it safely. Strong training for new and even some existing users was crucial and my technical team received a high number of service desk calls to "undo" mistakes.

That suite though proved to be the best on the market for meeting our income management requirements several times over. We'd had it in place for a very long time, because it kept winning our tenders and being awarded our contracts. The most recent was for a 3 year term, due to expire on the 31st March 2018. It carried a 6 month notice period (October 2017) for the negotiation of any changes, renewals, cancellations, etc. and so in the summer of 2017 with time to spare we instigated the necessary internal and external conversations around the options available to meet our income management needs going forwards.

Unfortunately, over the months that followed we were unable to reach an agreement of terms with our incumbent supplier and the negotiations broke down. Having suspected that might be the case early on in the process, we acknowledged that we needed to be prepared for being in a position of either having to a) renew the contract on the suppliers terms or b) replace the entire suite of products with technologies that we already had available in-house! This second option was accepting that running a new tender exercise to bring in a completely new supplier with new software would be near-on impossible. And so we quickly set to work to see what might be viable.

Now, I've blogged before about how in Barnsley we're very lucky to have an outstanding software development team on our payroll! By the end of September 2017 they had unbelievably created a proof of concept so good, that it demonstrated a clear capability of meeting all of our income management needs! Best of all, subject to suitable resourcing and a financial input it could be operational by the end of February 2018 - a whole month before the incumbent software expired! Stakeholder agreements were sought and suddenly the race was on!

The solution was to be an in-house developed web-based system, created using the Microsoft DotNet Core framework, Entity Framework and SQL Server - as an organisation that primarily uses SAP and Microsoft technologies, this made for a great infrastructure fit and ensured it could be supported and maintained going forwards.

And so, the council committed £50K (from it's 2017/18 budget) to a 'replacement' project in return for what was expected to be a minimum £50K saving year on year from that point forward. And this was after taking into account any additional transactional charges that might result from this change. It cleared a path through some other planned projects and created an agile project team made up of key stakeholders from the IT development team, IT project management team, Internal Audit and Finance department. Following a Scrum methodology and using Microsoft DevOps (Visual Studio Team Services at the time), they ran fortnightly sprints as follows:

1. Develop outline software infrastructure and get a single self-service web form accepting online payments in test
2. Reconfigure remaining self-service and mediated web forms to take payments using the new software in test
3. Enable transaction tracking, reconciliation and refund capabilities in test
4. Prepare for inital launch (refunds, reports, admin portal install scripts, security context) in test
5. Live launch for a specific group of self-service web forms (waste management, e.g. order a bin, book a bulky collection)
6. Create functionality to transfer monies between internal accounts
7. Launch remaining self-service eForms to live. Begin configuration of mediated shopping basket functionality
8. Complete and launch mediated basket
9. Training and rollout of solution plus increase code coverage regarding automated testing.
10. Improve transfer functionality per feedback from stakeholder group.
11. Develop new credit note requirements that have emerged from stakeholder group.
12. Develop functionality to allow cash income to be submitted to the centre.
13. Creation of routines for migration of historic data, final updates and tweaks requested by the stakeholder group.
14. Launch of cash submissions, close down of previous software suite and migration of historic data
15. Tidy up of loose ends

Now, all of that took us right up to the wire but by the end of March 2018 we had succesfully moved from the previous suite of software products, over to our new single in-house solution. Sure, there were teething issues and since the end of the project we've added in some new features and resolved a few bugs. But we now see significantly fewer service desk jobs as a support team! Our staff are using a modern, responsive, well performing product that doesn't require double keying over several outdated interfaces anymore. We're absolutely thrilled with it and in the fullness of time would love to open it up for other local authorities to use.

That said, we're conscious of the GovPay offer from the Government Digital Service (which sadly wasn't available to local authorities when all of this started for us - they were piloting with only a few select councils) and we haven't yet decided how best to actually make it available. Should we open source it on GitHub or multi-tenant it and run it as a SaaS offer in the cloud?
