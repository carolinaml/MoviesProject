# 🎬 MoviesProject

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Project Status](https://img.shields.io/badge/status-active-success.svg)]()

A modern and robust web application designed for exploring, managing, and cataloging movies and TV shows. **MoviesProject** enables users to discover the latest releases, search for their favorite titles, manage personalized watchlists, and view detailed information including cast, crew, and community ratings.

---

## ✨ Features

- **🔍 Advanced Search & Filtering:** Find movies by title, genre, release year, or rating.
- **📑 Comprehensive Details:** In-depth media profiles displaying synopses, cast details, trailers, and recommended titles.
- **👤 User Profiles & Custom Lists:** Secure account creation to add movies to a "Favorites" list or a "Watchlist".
- **⭐ Rating System:** Allows users to rate and write detailed reviews for specific titles.
- **📱 Fully Responsive Design:** Clean UI optimized for seamless browsing on mobile, tablet, and desktop devices.

---

## 🛠️ Tech Stack

### Backend & Core Architecture
- **Language & Runtime:** C# / .NET 8 Web API
- **Architecture:** Clean Architecture / DDD principles focusing on scalability and security
- **Database:** SQL Server / PostgreSQL (via Entity Framework Core)
- **Authentication:** Secure identity management utilizing JWT (JSON Web Tokens)


### Third-Party Integrations
- Integrated with [The Movie Database (TMDb) API](https://www.themoviedb.org/documentation/api) for real-time media data fetching.

---

## 🚀 Getting Started

Follow these steps to get a local copy of the project up and running:

### Prerequisites
- **.NET 8 SDK** or higher
- **Node.js** (v18 or higher)
- A valid TMDb API Key

### 1. Clone the Repository
```bash
git clone [https://github.com/carolinaml/MoviesProject.git](https://github.com/carolinaml/MoviesProject.git)
cd MoviesProject

```

### 2. Configure Environment Variables

Set up your connection strings and API credentials in your `appsettings.json` (backend) and `.env` file (frontend):

```env
API_KEY_TMDB=your_tmdb_api_key_here
DATABASE_URL=your_database_connection_string
JWT_SECRET=your_secure_jwt_secret_key

```

### 3. Run the Backend API

```bash
cd backend
dotnet restore
dotnet run

```

### 4. Run the Frontend Application

```bash
cd frontend
npm install
npm run dev

```

The application will be accessible at `http://localhost:3000` (or your configured local development port).

---

## 📁 Project Structure

```text
MoviesProject/
├── backend/            # Server-side logic, controllers, and database context
│   ├── Core/           # Domain models and application interfaces
│   ├── Infrastructure/ # Data context, repository implementations, and external services
│   └── API/            # Controllers and endpoint configurations
├── frontend/           # Single Page Application frontend
│   ├── public/         # Static assets
│   └── src/            # Components, hooks, pages, and API services
└── README.md

```

---

## 🛣️ Roadmap

* [ ] Implement global Dark Mode toggle.
* [ ] Add analytics dashboard for user watching habits and watch-time tracking.
* [ ] Implement real-time discussion boards using WebSockets/SignalR.
* [ ] Add social features to share watchlists directly with other users.

---

## ✒️ Author

Developed with ❤️ by **[Carolina ML](https://www.google.com/search?q=https://github.com/carolinaml)**.

```
