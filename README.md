A ⊕ jellel jelölt részfeladatok gondolkodtatóbb, szorgalmi feladatok plusz pontért.

Készíts WinForms-os alkalmazást.

Adatszerkezet:

Pekaru:
 - nev: string
 - ar: int
 - laktozmentes: bool
 + Nev { get; set; } : string
 + Ar { get; set; } : int
 + Laktozmentes { get; set; } : bool
 + ToString(): string

A ToString függvény az alábbi jellegű szöveget adja vissza: "Pogácsa (50 Ft / db)"

Pekseg:
 - nev: string
 - termekek: List<Pekaru>
 - alapitva: DateTime
 + Nev { get; set; } : string
 + Termekek { get; } : List<Pekaru>
 + Alapitva { get; } : DateTime
 + ToString(): string

A ToString függvény az alábbi jellegű szöveget adja vissza: "Kovács Pékség - 2020. 11. 10."


Az alkalmazás 2 tab-ból álljon, l. a mellékelt ábrákat:

1. tab: Adatok
  Pékáruk:
    Egy egyszerű formon meg lehessen adni új pékárukat.
    Az adatok megadása után ezeket adjuk hozzá a listboxhoz.
      A listából elemeket lehessen törölni.
      Elemre kattintáskor a pékáru adatait töltse vissza a formba.
      ⊕ Találj ki egy megoldást, hogy létező pékárut is lehessen szerkeszteni, ne kelljen ehhez létezőt törölni és újra megadni.

  Pékségek:
    Egy egyszerű formon meg lehessen adni új pékárukat.
    Az alapítás dátuma a hozzáadás ideje legyen.
    Az adatok megadása után ezeket adjuk hozzá egy ListBox-hoz.
    Egy pékség kijelölésekor jelenítsük meg a hozzáadott pékárukat.
    ⊕ Ha törlünk egy pékárut, akkor a hozzá tartozó pékségben se maradjon bent "fantom adat".

  Ha a van kijelölve pékség és pékáru, akkor az alsó "+" gombbal lehessen a pékséghez pékárut hozzáadni.

2. tab: Statisztikák
  A listát tabváltáskor kitölti az aktuális pékségek adataival.
  A lista elemére kattintva megjelennek az alábbi információk jobb oldalt:
    - Pékség
    - A pékáruk darabszáma
    - Átlagos ára
    - A legolcsóbb / legdrágább termékek neve és ára
    - A laktózmentes termékek darabszáma, és aránya (%-ban).
    ⊕ Egyszerű szöveg helyett válassz minden adatnak egy megfelelő komponenst. Ezeket ne lehessen szerkeszteni!
