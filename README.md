# Micro-Restaurant-Microservices-Example
Micro Restaurant - .Net Core 5.0 Microservices Example


**Add to Azure:**
```
1. Add Service Bus Namespace name as microRestaurant.
2. Add Topics name as checkoutmessagetopic, orderpaymentprocesstopic and orderupdatepaymentresulttopic.
3. Add Queue name as checkoutqueue.
4. Add Subscription name as microOrderSubscription on the checkoutmessagetopic.
5. Add Subscription name as microPayment on the orderpaymentprocesstopic.
6. Add Subscription name as emailSubscription and microOrderSubscription on the orderupdatepaymentresulttopic.
7. And generate Primary Connection String on the Shared access policies.
```


# Architecture

![Alt text](https://github.com/sinanguc/Micro-Restaurant-Microservices-Example/blob/main/Documents/Architecture.png?raw=true "Architecture")
