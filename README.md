# Hello World SPA (.NET 9 + HTML/CSS/TypeScript)

A minimalist Single Page Application using ASP.NET Core 9 as a static file host, with TypeScript for frontend logic and no Razor/Blazor.

## 🚀 Run Locally
```bash
npm install -g typescript
npm install
dotnet build
dotnet run --launch-profile http
```
Access: [http://localhost:8080](http://localhost:8080)

## 📦 Docker
```bash
docker build -t helloworld-spa .
docker run -d --name HelloWorldSpa -p 8080:8080 helloworldspa
```

## 🚢 Deploy to Heroku
```bash
heroku login
heroku container:login

docker tag helloworldspa registry.heroku.com/heroku-hello-world-app/web
docker push registry.heroku.com/heroku-hello-world-app/web
heroku container:release web -a heroku-hello-world-app
heroku open -a heroku-hello-world-app
```

## 📁 Project Structure
```
HelloWorldSpa/
├── HelloWorldSpa.sln
├── HelloWorldSpa.csproj
├── Program.cs
├── Dockerfile
├── tsconfig.json
├── .gitignore
├── README.md
├── src/
│   └── main.ts
└── wwwroot/
    ├── index.html
    ├── styles.css
    └── dist/main.js (compiled)
```
