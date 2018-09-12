---
layout: post
title:  "Coding for low-code"
date:   2018-09-10
categories: coding
tags: work life other
intro: We're building our own low-code solution and when we're finished, we're going to open it up as a SaaS platform for other council's to use.
---
In Barnsley, we're very lucky that we have an in-house web development team. They're the people behind [our website](https://www.barnsley.gov.uk), our eForms and our CRM amongst other things. They're responsible for building accessible, compliant solutions that meet the needs of our citizens and our departmental staff and they do that very well. I manage that team and I'm incredibly proud to say so.

Today our website scores 94/100 for desktop experience and 100/100 on mobiles according to [Google PageSpeed](https://developers.google.com/speed/pagespeed/insights/?url=barnsley.gov.uk). It was [recently overhauled](https://www.linkedin.com/pulse/new-look-barnsley-council-website-aidan-minton/) with an 80% improvement in response speeds. We gave it [progressive capabilities](../council-knows-whats-appnin/) to function as an app back in November and we have more big plans for its future.

Right now though we're focussing on our eForms. More than that actually. Our transactional platform. We're calling it our Digital Customer Service Platform (DCSP for short), and it will allow our customers to interact with us, anytime, from anywhere and by any means - beyond them just being able to read information on our web pages. 

I've blogged before about just how big a task it is to [digitally enable all of our 630+ business processes](../the-challenge-of-digitising-council-services) and we're very mindful of that. We know that if we're not careful, the more we develop, the more we'll have to maintain and in fact today we have a library of over 250 eForms that we manage individually.

When we update our branding styles or tone of voice guidelines, we have to apply them to each eForm seperately. When we take on a new coding technique on a new eForm build, we don't go back and retrofit it to previous builds - who has the time?! When a new eForm is required by our departments, they have to wait until we've finished building an earlier one. And so we recognised last year that we needed a new, more sustainable approach.

DCSP to the rescue. It's designed to be a single platform into which eForms can be developed without coding. It can be deployed to our departments such that they can design, set up, test and maintain their own eForms. It controls the presentation of every one that's published to ensure accessibility and usability standards are maintained. It can handle multilingual outputs, validations and integrations with ease.

Of course we have to actually code this thing first and that's an activity we started a few months ago. We've made some fantastic progress and already we're able to create new eForms, add fields, remove fields, amend fields, reorder fields, save drafts, publish versions, rollback versions and email submissions to departments.

In the fullness of time we'll be able to integrate submissions directly into departmental systems so they don't have to double key entries manually. We'll expand the types of fields that can be used from basic text boxes, textareas, radio buttons, checkboxes and file uploads to map location selectors, GPS locators, calendar date pickers, colour choices, multiple choice selectors, type ahead boxes, data driven fields, etc.

Publish in the cloud as a resilient SaaS solution, it will use an queuing mechanism to ensure citizens, residents and businesses can make submissions through it 24x7, 365. If any of our departmental systems are unavailable (down for upgrades for example), it will hold onto their entries until it's able to push them in, alerting support staff if a number of retries have failed.

It will manage customer profiles, linking in seamlessly with an access portal through which personal details, service accounts (e.g. council tax), passwords, eForm submissions and responses can be managed, monitored and tracked. 

Submissions are where this gets really interesting though as eForms are only one access channel. DCS will treat them as such. Actually, submissions will be received through webservice hooks - making them availalbe not only to the eForms, but also to IoT devices including the Amazon Echo, Google Home and Apple Pod. But more... our own IoT developments will be able to use them too. Our litter bins can report when they're almost full. Our vehicles can report defects as they arise (or preferable before they happen). Our street lights and traffic lights can report their own issues. Our electronic rat traps can alert us when they've caught something - we don't have to keep checking them.

The possibilities are endless. We recently learned that Land Rover Jaguar are working on a vehicle system that will identify potholes as their vehicles approach them and adjust the suspension of any colliding wheel to minimise the impact for the passengers. It will then tell any other nearby vehicles of the potholes location so that they can do the same. With our DCS solution, it could also tell us. It could report the pothole to us!

It's a big ambition and one that has the full backing of our Senior Management Team and Digital Leadership Team. I proposed the original idea back in October of last year and secured approval to progress it into business case. With support from colleagues that business case was accepted in July this year and an amount of funding released to secure resources for the 18/19, 19/20 and 20/21 financial years.

I'm obviously very excited the potential of this. I'm also very willing to work with any council's who would like to get involved with us and help make this thing a reality. Our code repository is cloud hosted and open to pull requests from authenticated parties. There's plenty of scope to help speed up the build and plenty of opportunity for other council's to take advantage of the system for their own organisations. Do please get in touch.

For now, I'll continue blogging updates as we progress. We're running fortnightly agile sprints with plannig sessions held every other Monday and review/retrospectives every other Friday. Our backlog is available within our source code repository and always open to new additions and ideas. I'll also blog about why we've chosen to build our own solution over buying one.