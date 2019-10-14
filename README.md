# AppSettings
Read application settings from different configuration files using configuration providers. Display the setting information in the browser. 

## Getting Started
These instructions will guide you on installing this project on your local computer. See deployment section for information on how to deploy the project on a live system.

## Prerequisites
To start working on this project you need to download and install the following components:

* .NET Core SDK (Software Development Kit)
* Visual Studio Code (Code editor)
* git (Distributed version control system)
* Clone this project from Github.

## Download and install

### Install .NET Core SDK
1. Get the latest version of .NET Core on the <a href="https://dotnet.microsoft.com/download">dotnet</a> web site.

2. When the installation is complete, open a new command prompt and run the following command:

> \\> dotnet --list

3. The command should print out information about the version, the runtime environment and a list of .NET Core SDKs installed. 

> .NET Core SDK (reflecting any global.json):<br>
> Version:   2.2.204<br>
> Commit:    8757db13ec<br>
>
> Runtime Environment:<br>
> OS Name:     Windows<br>
> OS Version:  10.0.17763<br>
> OS Platform: Windows<br>
> RID:         win10-x64<br>
> Base Path:   C:\Program Files\dotnet\sdk\2.2.204\<br>

Note: The information might be different on your system.

### Install Visual Studio Code
1. Download the latest version of <a href="https://go.microsoft.com/fwlink/?LinkID=534107">Visual Studio Code</a> installer for Windows.

2. Run the installer (VSCodeUserSetup-{version}.exe).

3. By default, Visual Studio Code is installed under C:\users\{username \AppData\Local\Programs\Microsoft VS Code.

### Install Git
> This procedure assumes you want to use a distributed version control system to contribute to this project. Git is not mandatory to develop or to simply run an ASP.NET Core web application. In this case, simply download the repository from Github using the ZIP file option.   

1. Download the latest version of the <a href="https://git-scm.com/download/win">git</a> installer for Windows.

2. Run the installer (Git-{version}-64-bit.exe).

3. The installer allow you to select the default text editor for Git. Accept the default if you prefer to change this later. 

4. When the installation is complete, open Git Bash and run the following command:

> \\> git --version

5. The command should print out information about the version.

> git version 2.22.0.windows.1

### Clone the project from Github
1. Create the directory on your local machine where you want this project to reside.

> \\> mkdir C:\Project<br>
> \\> cd .\Project 

2. Open your browser and navigate to this <a href="https://github.com/residentsystem/AppSettings">repository</a> on Github.

3. Next, get a copy of the project in a ZIP file or use the git clone command.

#### Download the ZIP file 
1. Under the repository name, click Clone or download.

2. Select Download ZIP.

3. Extract the ZIP file in your project folder (ex C:\Project).

#### Clone using git
1. Under the repository name, click Clone or download.

2. In the Clone with HTTPs section, copy the clone URL for the repository.

3. Open Git Bash.

4. Navigate to the project directory where you want the ptoject to be cloned (C:\Project).

5. Type git clone, and then paste the URL you copied in Step 2.

> \\>git clone https://github.com/residentsystem/AppSettings 

5. Press Enter. Your local clone will be created.

### Verify installation
1. Change the current working directory to the project folder and open the project using Visual Studio Code.

> \\> cd C:\Project\AppSettings<br>
> \\> code .

2. Using VS Code, select Terminal -> New Terminal. Inside the terminal, run the application.

> \\> dotnet run

3. The command should print information about the hosting environment, url and port listening.

> Hosting environment: Development<br>
> Content root path: C:\Data\Project\AppSettingsCore\AppSettings<br>
> Now listening on: https://localhost:5001<br>
> Now listening on: http://localhost:5000<br>
> Application started. Press Ctrl+C to shut down.

4. Open your browser and navigate to http://localhost:5000.

5. All settings contained in the following configuration files will be displayed in your browser.

* appsettings.json
* serversettings.json
* consolesettings.ini
* websitesettings.xml

## Deployment
1. Create a folder where you wish to have the application published. Change the current working directory to the project folder.

> \\> mkdir C:\Publish\AppSettings<br>
> \\> cd C:\Project\AppSettings

2. Run this command to publish the application.

> \\> dotnet publish -o "C:\Publish\AppSettings" -c Release

3. Copy the configuration files to the new publish folder.  

> \\> cp C:\Project\AppSettings\appsettings.json C:\Publish\AppSettings<br>
> \\> cp C:\Project\AppSettings\serversettings.json C:\Publish\AppSettings<br>
> \\> cp C:\Project\AppSettings\consolesettings.ini C:\Publish\AppSettings<br>
> \\> cp C:\Project\AppSettings\websitesettings.xml C:\Publish\AppSettings

4. Navigate to the publish folder and Run the project dll.

> \\> cd C:\Publish\AppSettings<br>
> \\> dotnet .\AppSettings.dll

5. The command should print information about the hosting environment, url and port listening but this time the hosting environment will indicate "Production".

> Hosting environment: Production<br>
> Content root path: C:\Data\Publish\AppSettings<br>
> Now listening on: http://localhost:5000<br>
> Now listening on: https://localhost:5001<br>
> Application started. Press Ctrl+C to shut down.<br>

6. Open your browser and navigate to http://localhost:5000.

7. All settings contained in the configuration files will be displayed in your browser.

8. The next step is to host the application on a web server.

### Host and deploy ASP.NET Core
When done publishing the app, you need to deploy the published files to a web server. For more information, read on how to <a href="https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/iis/?view=aspnetcore-2.2">host ASP.NET Core on Windows with IIS</a>.

## Built With
* Visual Studio Code - Code editor
* .NET Core SDK 2.2.204 - Open-source development platform

## Contributing
Please read CONTRIBUTING for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning
We use SemVer for versioning. For the versions available, see the tags on this repository.

## Authors
Eric Lacroix - Initial work

See also the list of contributors who participated in this project.

## License
This project is licensed under the MIT License - see the LICENSE file for details