# SlackbotAnchor
Access your slackbot from .Net

Begin with activating the Slackbot integration in slack to retrieve your token.

```csharp

var slackbot = new Slackbot("team name", "token");

slackbot.Post("#channel", "Hello from Slackbot")
```
