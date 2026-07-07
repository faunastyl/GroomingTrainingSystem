Grooming Training Notification System (MVP)
📖 Opis projektu

Projekt przedstawia prosty system powiadomień o szkoleniach groomerskich. Użytkownicy mogą być informowani o nowych szkoleniach dodawanych do systemu przez trenerów.

System został opracowany jako MVP (Minimum Viable Product) i stanowi wstępną implementację modelu danych oraz logiki biznesowej.

🧱 Główne założenia

W projekcie zastosowano podstawowe elementy programowania obiektowego:

Dziedziczenie – klasy Subscriber dziedziczą po klasie abstrakcyjnej User
Abstrakcja – klasa User definiuje wspólny interfejs dla użytkowników
Polimorfizm – metoda Notify() implementowana w klasach pochodnych
Metody statyczne – klasa TrainingValidator zawiera walidację danych
Przeciążanie metod – metoda AddTraining() posiada różne wersje
🔔 Wzorzec projektowy

W projekcie zastosowano wzorzec Observer, gdzie:

TrainingService pełni rolę obiektu obserwowanego (Subject)
użytkownicy (User) są obserwatorami (Observers)
po dodaniu nowego szkolenia system automatycznie wysyła powiadomienia
🧩 Struktura systemu
Training – model danych szkolenia
User – klasa abstrakcyjna użytkownika
Subscriber – użytkownik otrzymujący powiadomienia
TrainingService – logika zarządzania szkoleniami i powiadomieniami
TrainingValidator – walidacja danych (metody statyczne)
🚀 Status projektu

Projekt ma charakter MVP i stanowi podstawę do dalszego rozwoju systemu, m.in. o:

interfejs użytkownika
bazę danych
system wysyłki e-mail/SMS

📌 Autor Bożena Czempas-Chowaniec

Projekt edukacyjny – podstawy programowania obiektowego (C#)

## Dalszy rozwój projektu

Szkolenia mają charakter stacjonarny i odbywają się w określonym miejscu oraz czasie. Mogą trwać od jednego dnia do kilku tygodni. Po zakończeniu przechodzą do archiwum i nie są już dostępne do zapisów.

Docelowo system będzie umożliwiał:

- przeglądanie dostępnych szkoleń,
- wyszukiwanie szkoleń po mieście,
- wyszukiwanie szkoleń po trenerze,
- dodawanie i zarządzanie szkoleniami przez trenerów,
- powiadamianie zainteresowanych osób o nowych szkoleniach.

Planowane funkcjonalności:

- integracja z bazą danych (Oracle, MariaDB lub MongoDB),
- logowanie trenerów i organizatorów,
- system subskrypcji powiadomień,
- wysyłka wiadomości e-mail,
- interfejs użytkownika,
- filtrowanie i wyszukiwanie szkoleń.

## Documentation

- [Product Vision](docs/ProductVision.md)
- [Database](docs/Database.md)
