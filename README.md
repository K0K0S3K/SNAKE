# 🐍 Snake Game

<div align="center">
  <img src="https://img.shields.io/badge/C%23-12.0-blue.svg?style=for-the-badge&logo=csharp&logoColor=white" alt="C# Standard" />
  <img src="https://img.shields.io/badge/.NET-8.0-purple.svg?style=for-the-badge&logo=dotnet&logoColor=white" alt="Framework" />
  <img src="https://img.shields.io/badge/Raylib--cs-6.0.0-orange.svg?style=for-the-badge" alt="Library" />
  <img src="https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge" alt="License: MIT" />
  <img src="https://img.shields.io/badge/build-passing-brightgreen.svg?style=for-the-badge" alt="Build Status" />
</div>

<br />

**Snake Game** to nowoczesna implementacja klasycznej gry arcade, stworzona w języku **C#** przy użyciu biblioteki graficznej **Raylib**. Projekt skupia się na czystej architekturze, płynności działania oraz responsywnym systemie sterowania.

---

## 🚀 Funkcje

* 🎮 **Klasyczna Rozgrywka**: Dynamiczny ruch węża i zbieranie owoców (Snacks).
* 🏆 **System Rekordów**: Automatyczny zapis i odczyt najwyższego wyniku (**Highest Score**) z pliku lokalnego.
* 🏁 **Warunki Wygranej**: Gra przewiduje zwycięstwo po osiągnięciu maksymalnej długości (502 segmenty).
* ⚡ **Wydajność**: Renderowanie oparte na kafelkach (Grid System) zapewniające stałą liczbę klatek na sekundę.
* 🖥️ **User Interface**: Dedykowane ekrany startowe, pauzy oraz zakończenia gry z wynikami.

---

## 🛠️ Specyfikacja Techniczna

### Technologie
* **Język programowania:** C# 12.0
* **Framework:** .NET 8.0
* **Silnik graficzny:** [Raylib-cs](https://github.com/ChrisDill/Raylib-cs) (v6.0.0)
* **Format danych:** Pliki tekstowe (`.txt`) dla systemu zapisu.

### Architektura
Projekt został podzielony na moduły logiczne, co ułatwia jego rozbudowę:
* `Game`: Główny kontroler stanu gry i pętli zdarzeń.
* `Snake`: Logika ruchu, obsługa wejść (Input) oraz zarządzanie ciałem węża.
* `Snack`: Generator losowych punktów na mapie.
* `Grid`: System renderowania tła i pomocniczej siatki.

---

## 💻 Instalacja i Uruchomienie

### Wymagania
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Kroki do uruchomienia
1. Sklonuj repozytorium na swój dysk:
   ```bash
   git clone [https://github.com/K0K0S3K/snake.git](https://github.com/K0K0S3K/snake.git)
    </div>

<br />

<div align="center">
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Step-02-blue%3Fstyle%3Dfor-the-badge%26logo%3Ddotnet%26logoColor%3Dwhite" alt="Krok 2" />
<br />

Przywracanie Zależności Pobierz niezbędne pakiety NuGet (w tym Raylib-cs):
Bash

dotnet restore

</div>

<br />

<div align="center">
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Step-03-brightgreen%3Fstyle%3Dfor-the-badge%26logo%3Ddotnet%26logoColor%3Dwhite" alt="Krok 3" />
<br />

Kompilacja i Start Uruchom grę bezpośrednio z poziomu konsoli:
Bash

dotnet run

</div>
🎮 Sterowanie

<div align="center">
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Movement-Arrows-orange%3Fstyle%3Dfor-the-badge" alt="Strzałki" />
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Action-Enter-red%3Fstyle%3Dfor-the-badge" alt="Enter" />
<br />
<br />
Klawisz	Akcja
<kbd>▲</kbd> Strzałka w górę	Ruch w górę
<kbd>▼</kbd> Strzałka w dół	Ruch w dół
<kbd>◄</kbd> Strzałka w lewo	Ruch w lewo
<kbd>►</kbd> Strzałka w prawo	Ruch w prawo
<kbd>↵</kbd> Enter	Start / Restart gry

</div>
📝 Licencja

Projekt udostępniany na licencji MIT. Więcej informacji w pliku LICENSE.

<div align="center">
<sub>Autor: <b>Adam Kwiatkowski</b> • 2024</sub>
</div>
   
