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
📌 Autor

Projekt edukacyjny – podstawy programowania obiektowego (C#)