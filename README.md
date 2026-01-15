# PPSA CRM System

This is a CRM system for PPSA, built with a .NET backend and a Next.js frontend.

## Prerequisites

- .NET 8 SDK
- Node.js 20+
- PostgreSQL

## Backend Setup

1. Navigate to the `backend` directory.
2. Configure your connection string in `secrets.json` by running: `dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Your_PostgreSQL_Connection_String"`
3. Apply database migrations: `dotnet ef database update --startup-project PPSA.CRM.API`
4. Run the API: `dotnet run --project PPSA.CRM.API`

## Frontend Setup

1. Navigate to the `frontend` directory.
2. Install dependencies: `npm install`
3. Run the development server: `npm run dev`
