# Database Design

## Cel projektu

System umożliwia publikowanie i wyszukiwanie szkoleń groomerskich odbywających się stacjonarnie w określonym miejscu i czasie. Szkolenia mają charakter wydarzeń jednorazowych lub cyklicznych o ograniczonym czasie trwania. Po zakończeniu przechodzą do archiwum i nie można już wziąć w nich udziału.

---

## Typy użytkowników

### Gość (Visitor)

Nie wymaga logowania.

Może:

* przeglądać szkolenia,
* wyszukiwać szkolenia po mieście,
* wyszukiwać szkolenia po trenerze,
* przeglądać szkolenia archiwalne.

### Subskrybent (Subscriber)

Nie musi posiadać pełnego konta użytkownika.

Może:

* zapisać adres e-mail do powiadomień,
* otrzymywać informacje o nowych szkoleniach.

### Trener / Organizator (Trainer)

Posiada konto i loguje się do systemu.

Może:

* dodawać szkolenia,
* edytować własne szkolenia,
* usuwać własne szkolenia,
* przeglądać historię dodanych szkoleń.

---

## Tabela: Trainers

| Pole         | Typ     |
| ------------ | ------- |
| Id           | int     |
| Name         | varchar |
| Email        | varchar |
| PasswordHash | varchar |

---

## Tabela: Trainings

| Pole        | Typ      |
| ----------- | -------- |
| Id          | int      |
| Title       | varchar  |
| Description | text     |
| City        | varchar  |
| StartDate   | datetime |
| EndDate     | datetime |
| TrainerId   | int      |

Relacja:

* jeden trener może dodać wiele szkoleń.

---

## Tabela: Subscribers

| Pole      | Typ      |
| --------- | -------- |
| Id        | int      |
| Email     | varchar  |
| CreatedAt | datetime |
| IsActive  | bool     |

---

## Logika biznesowa

1. Trener dodaje nowe szkolenie.
2. System zapisuje szkolenie w bazie danych.
3. Mechanizm Observer wykrywa dodanie nowego szkolenia.
4. Subskrybenci otrzymują powiadomienie o nowym wydarzeniu.
5. Po zakończeniu szkolenia jest ono automatycznie oznaczane jako archiwalne.

---

## Plan rozwoju

1. Integracja z bazą danych Oracle, MariaDB lub MongoDB.
2. Implementacja logowania trenerów.
3. Implementacja systemu subskrypcji e-mail.
4. Dodanie filtrowania szkoleń według miasta, trenera i dat.
5. Automatyczna archiwizacja zakończonych szkoleń.
6. Integracja z usługą wysyłki wiadomości e-mail.
