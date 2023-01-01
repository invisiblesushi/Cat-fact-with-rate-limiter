# Cat-fact-with-rate-limiter
Application to get data from catfact api with rate limiter.
Utilizing Polly libary and https://catfact.ninja/ api.

Application prints out a list of all cat breeds and some facts provided by the api, and throttles the rate limit to 2 requests pr 10 secounds.

```
Policy.RateLimitAsync(2, TimeSpan.FromSeconds(10));
```
