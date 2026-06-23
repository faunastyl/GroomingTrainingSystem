# Database Design (MVP)

## Cel

Przygotowanie struktury bazy danych dla systemu powiadomień o szkoleniach groomerskich.

Na obecnym etapie dane przechowywane są w pamięci aplikacji. W kolejnych etapach planowana jest integracja z relacyjną bazą danych (np. MariaDB lub Oracle).

---

## Tabela: Users

Przechowuje informacje o użytkownikach systemu.

| Pole | Typ |
|--------|--------|
| Id | int |
| Email | varchar |
| CreatedAt | datetime |

---

## Tabela: Trainings

Przechowuje informacje o szkoleniach.

| Pole | Typ |
|--------|--------|
| Id | int |
| Title | varchar |
| City | varchar |
| TrainerName | varchar |
| Date | datetime |
| Description | text |

---

## Tabela: Subscriptions

Przechowuje informacje o subskrypcjach użytkowników.

| Pole | Typ |
|--------|--------|
| Id | int |
| UserId | int |
| CreatedAt | datetime |

---

## Relacje

- Jeden użytkownik może posiadać jedną lub wiele subskrypcji.
- Użytkownicy otrzymują powiadomienia o nowych szkoleniach.
- Szkolenia są dodawane przez trenerów i przechowywane w tabeli Trainings.

---

## Plan rozwoju

1. Integracja z bazą MariaDB lub Oracle.
2. Zastąpienie list przechowywanych w pamięci aplikacji zapytaniami do bazy danych.
3. Dodanie repozytoriów danych (Repository Pattern).
4. Dodanie wyszukiwania szkoleń po mieście i trenerze.
5. Integracja z systemem powiadomień e-mail.
