# Google URL Shortener App

My first attempt at learning C# by developing a Google URL Shortener desktop
application using WPF.

I developed this mostly out of laziness because I found that the process of
going to [goo.gl](https://goo.gl/) and shortening a URL took too long (it
actually doesn't take that long at all, I'm just that lazy).

This app is simply a GUI that uses the
[Google URL Shortener API](https://goo.gl/1uh11c) to do the same exact thing as
goo.gl, but without having to go to a web browser to do it. The only times the
browser is really need is to get an API Key, and maybe to paste the URL if you
plan on using it.

### Requirements

* Have .NET Framework >= 4.5.2
* Enable the [Google URL Shortener API](https://goo.gl/pZbaF)
* Prepare an API Key [here](https://goo.gl/kkvx2K)

### Usage

* Clone the repo to a directory of your choice and `cd` to that directory
* Open `GoogleURLShortenerApp.sln` in Visual Studio and Build (Ctrl + Shift + B)
* Run `GoogleURLShortenerApp.exe`
