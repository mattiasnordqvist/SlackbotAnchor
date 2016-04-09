# not created by, affiliated with, or supported by Slack Technologies, Inc.

Access your [slack](https://slack.com/)bot from .Net

## Slackbot

Activate the Slackbot integration in slack to retrieve your token.

```csharp

var slackbot = new Slackbot("team name", "token");

slackbot.Post("#channel", "Hello from Slackbot")
```

## [Incoming webhook](https://slack.com/apps/A0F7XDUAZ-incoming-webhooks)

```csharp

var incomingWebhook = new IncomingWebhook("yourwebhookurl");

incomingWebhook.Post(new Message(){...})
```
