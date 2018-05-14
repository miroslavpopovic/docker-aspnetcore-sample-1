# Docker and ASP.NET Core 2.1

A sample code for the presentation "Docker and ASP.NET Core 2.1"

Some docker and config files taken from (inspired by) [Quick intro to Docker and Docker Compose: Angular, ASP.NET Core and Postgres app](
https://blog.codingmilitia.com/2018/01/31/quick-intro-to-docker-and-docker-compose-angular-aspnetcore-postgres-app) post by [@joaofbantunes](https://github.com/joaofbantunes).

## Running the sample

Make sure you have the latest Docker for Windows installed.

Run the following console command from the root folder:

    docker-compose build

Following with:

    docker-compose up

> **Note**
>
> If you get 401 errors in dev console when application is open in browser (http://localhost:5110) you need to set new API access tokens in `/BoardGames.Client/aurelia_project/environments/*.js` files. To get new API token open this URL in browser http://localhost:5110/get-token?admin=true.
>
> After the token is updated, repeat the process of building and starting the docker compose services.

## Download

- [MS Network 2018 presentation](msnetwork-2018-docker-and-aspnet-core.pptx)
