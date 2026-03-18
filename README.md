# 🐍 Snake Game

<div align="left">
  <img src="https://img.shields.io/badge/.NET-8.0-purple.svg?style=for-the-badge&logo=dotnet&logoColor=white" alt="Framework" />
  <img src="https://img.shields.io/badge/Raylib--cs-6.0.0-orange.svg?style=for-the-badge" alt="Library" />
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
* [Raylib-cs](https://github.com/ChrisDill/Raylib-cs) (v6.0.0)

### Kroki do uruchomienia
1. Sklonuj repozytorium na swój dysk:
   ```bash
   git clone [https://github.com/K0K0S3K/snake.git](https://github.com/K0K0S3K/snake.git)
2. Zainstaluj bibliotekę raylib
   ```bash
   https://github.com/raylib-cs/raylib-cs
3. Uruchom projekt
  ```bash
  dotnet run
