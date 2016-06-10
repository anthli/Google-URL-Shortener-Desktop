# Google URL Shortener App

A Google URL Shortener desktop application for Windows written in C# and WPF.

I developed this mostly out of laziness because I found that the process of
going to [goo.gl](https://goo.gl/) and shortening a URL took too long (even
though it doesn't take that long at all, I'm just that lazy). It's essentially
a GUI that uses the [Google URL Shortener API](https://goo.gl/1uh11c) to do the
same exact thing as goo.gl, but without having to go to a web browser to do it.
The only times the browser is really need is to get an API Key, and maybe to
paste the URL.

### Requirements

* Have .NET Framework >= 4.5.2
* Enable the [Google URL Shortener API](https://goo.gl/pZbaF)
* Prepare an API Key [here](https://goo.gl/kkvx2K)

### Usage

* Clone the repo to a directory of your choice
* Open `GoogleURLShortenerApp.sln` and Build (Ctrl + Shift + B)
* Run `GoogleURLShortenerApp.exe`
