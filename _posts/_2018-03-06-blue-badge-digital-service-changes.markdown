---
layout: post
title:  "Blue Badge digital service changes"
date:   2018-03-06
categories: work life other
intro: After a little "got lost" detour around Manchester, I attend the Department for Transport's local authority event today
---
I spent today with the Department for Transport at their Blue Badge Digital Service Local Gov event in Manchester. Whilst that's a bit of a mouthful as event titles go, it was a fairly straight forward affair, set up to discuss the future of the service and how proposed changes to it in the 2019 New Year would impact council's.

<blockquote class="twitter-tweet" data-lang="en"><p lang="en" dir="ltr">After a little “got lost” detour, finally made it to the <a href="https://twitter.com/transportgovuk?ref_src=twsrc%5Etfw">@transportgovuk</a> Blue Badge Digital Service Local Authority Event at the Manchester Fire &amp; Rescue Service training centre. <a href="https://t.co/n6iAkFJcRo">pic.twitter.com/n6iAkFJcRo</a></p>&mdash; Richard Kingston (@kingstonrichard) <a href="https://twitter.com/kingstonrichard/status/970953524178817024?ref_src=twsrc%5Etfw">March 6, 2018</a></blockquote>
<script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>

The Blue Badge scheme was introduced in 1971 to help disabled people with severe mobility problems to access goods and services, by allowing them to park close to their destination. Central Government (DfT in particular have the ministerial mandate) are responsible for the legislation that sets out the framework for the scheme, but Local Government Authorities are responsible for it's administration and enforcement - which includes the carrying out of assessments on citizen applications to it.

As part of their framework offer, the DfT in partnership with Northgate, provide an online solution that both citizens and councils can use in the running of that day to day operation. Citizens can complete their application forms via the Gov.UK website, and council's can process them to an end result of either approved or rejected. But come December 31st 2018, the contract with Northgate for that arrangement comes to an end and with that in mind, a competitive tender exercise is underway to find its successor.

While there is a tender running, a lot of what I learned today needs to be kept confidential and indeed only direct employees of local government authorities or NHS organisations were permitted to attend the session. We even signed a disclaimer to that effect, so it's all being very appropriately managed. But the general gist is that there's some work to be done in readiness for *some* changes to come. We ([@LisaT1980](https://twitter.com/lisat1980)) and I left with a good idea of what we need to do and how we can ready ourselves.

The biggest surprise of the day for me though was that there are 207 council's running the scheme on behalf of the DfT and none of them do it in the same way. They all have their own bespoke implementations, custom business processes, preferred assessment mechanisms and approaches to enforcement. The DfT don't have the power to force a standard approach on council's and so each does what works best for their citizens. With that being the case, my software development team are free to build a solution for Barnsley that meets its needs.

## Here's how I'd like to see the whole thing work...

Citizen's find their way to the Blue Badge pages on either their own council's website, or on GovUK. If the latter, their asked to confirm their postal code which identifies them as a Barnsley citizen in our case. From here, they are redirect to our website where they can complete an online application form. The detail from that form is integrated into our local case management system where our assessment personnel process the detail to determine an end result. That end result is communicated back to the citizen and to the DfT for their central records. At any time, our staff can query the DfT's central records in order to prevent fraud and to double check previous application details (especially handy in the case of renewals).

## Here's what I think will end up happening...

Citizen's will find their way to the Blue Badge pages on either their own council's website or on GovUK. If the former, they'll be pushed to GovUK to make an online application. The detail of their application will be posted into the DfT's central records and also into our local case management system. We'll process it and update the central record when we're done.

## In summary

That latter approach is much simpler for the customer and for my team to technically implement, but it detracts from the scenario I've painted in previous blog posts of the council having a full suite of eForms on it's website, integrated into a customer portal and branded seamlessly across all potential customer devices. It's a shame that we'd have to "switch off" our own local eForm and send customers to a national one, but I suppose it does make sense.

I suppose watch this space.