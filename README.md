Oto profesjonalny plik README.md przygotowany na podstawie dostarczonych przez Ciebie plików źródłowych projektu.
🐍 Snake Game (Raylib-cs)

Klasyczna gra Snake zrealizowana w języku C# przy użyciu biblioteki Raylib-cs. Projekt charakteryzuje się minimalistycznym stylem wizualnym, systemem zapisu rekordów oraz obsługą niestandardowych czcionek.

🎮 Funkcje Gry

    System Punktacji: Każda zjedzona przekąska zwiększa wynik o 10 punktów.

Persistent High Score: Gra automatycznie wczytuje i aktualizuje Twój najlepszy wynik w pliku highest.txt.

Warunki Wygranej: Osiągnięcie rozmiaru 502 segmentów oznacza całkowite zwycięstwo.

Dynamiczna Rozgrywka: Mechanika poruszania się z interwałem czasowym 0.2s zapewniająca klasyczne odczucia z gry.

Estetyka: Wykorzystanie fontu monogram.ttf (autor: Vinicius Menezio) oraz kontrastowej kolorystyki (Red, Lime, Yellow).

🛠️ Technologie i Biblioteki

    Język: C#.

Framework: .NET 8.0.

Biblioteka Graficzna: Raylib-cs (Version 6.0.0).

Zasoby: Czcionka Monogram w formacie TTF.

🚀 Jak uruchomić?
Wymagania

    .NET 8.0 SDK

Instrukcja

    Sklonuj repozytorium:
    Bash

git clone https://github.com/K0K0S3K/SNAKE.git

Przejdź do folderu projektu:
Bash

cd SNAKE

Uruchom aplikację za pomocą CLI:
Bash

    dotnet run

🕹️ Sterowanie

    Strzałki (Góra/Dół/Lewo/Prawo): Zmiana kierunku ruchu węża.

Dowolny Klawisz: Start gry, restart po przegranej lub powrót do menu po wygranej.

📁 Struktura Projektu

    Program.cs – Inicjalizacja okna (841x541) oraz główna pętla gry.

game.cs – Logika stanów gry (Start, Play, GameOver, Win) i obsługa jedzenia.

snake.cs – Mechanika poruszania się, wykrywanie kolizji ze ścianami i samym sobą.

snack.cs – Losowe generowanie pozycji "przekąski" na planszy.

grid.cs – Renderowanie siatki pola bitwy (28x18 komórek).

Autor: Adam Kwiatkowski
