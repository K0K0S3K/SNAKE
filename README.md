🐍 Snake Game

Klasyczna implementacja gry Snake napisana w języku C# z wykorzystaniem potężnej biblioteki graficznej Raylib. Projekt charakteryzuje się czystym kodem, systemem zapisu najlepszych wyników oraz responsywnym sterowaniem.
🚀 Funkcje Projektu

    Dynamiczna Rozgrywka: Płynny ruch węża i zbieranie przekąsek (Snacks).

    System Punktacji: Zbieranie punktów (każdy owoc to 10 pkt) oraz automatyczny zapis Highest Score do pliku tekstowego.

    Warunki Zwycięstwa: Gra przewiduje scenariusz ukończenia przy osiągnięciu określonej długości węża (502 segmenty).

    Wykrywanie Kolizji: Zaawansowany system sprawdzający kolizje ze ścianami oraz z samym sobą.

    Menu Startowe i Koniec Gry: Przejrzyste ekrany informacyjne z autorem projektu.

🛠️ Wykorzystane Technologie

    Język: C# (wersja wspierana przez .NET 8).

    Platforma: .NET 8.0.

    Biblioteka Graficzna: Raylib-cs (v6.0.0) – wrapper C# dla popularnej biblioteki Raylib, zapewniający wysoką wydajność renderowania 2D.

    Zarządzanie Projektami: Pliki rozwiązania .sln oraz projektu .csproj zgodne z nowoczesnymi standardami SDK.

📁 Struktura Projektu

    src/Program.cs – Punkt wejściowy aplikacji, inicjalizacja okna i pętla główna.

    src/game.cs – Główna logika gry, zarządzanie stanami (Start, Game, GameOver, Win).

    src/snake.cs – Implementacja ruchu węża, wejść użytkownika i kolizji.

    src/grid.cs – Klasa odpowiedzialna za renderowanie tła gry w formie siatki.

    src/snack.cs – Logika generowania i rysowania "jedzenia".

    highest.txt – Plik przechowujący rekord punktowy.

💻 Instrukcja Uruchomienia Lokalnie

Aby uruchomić projekt na swoim komputerze, upewnij się, że masz zainstalowane .NET 8 SDK.

    Sklonuj repozytorium:
    Bash

git clone https://github.com/twoj-uzytkownik/snake.git
cd snake

Przywróć zależności:
Bash

dotnet restore

Zbuduj i uruchom projekt:
Bash

    dotnet run

🎮 Sterowanie

Używaj strzałek na klawiaturze, aby sterować kierunkiem węża:

    ⬆️ Góra

    ⬇️ Dół

    ⬅️ Lewo

    ➡️ Prawo

👤 Autor

Adam Kwiatkowski
