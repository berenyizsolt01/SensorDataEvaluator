# Mérési Adat Ellenőrző

Ez egy egyszerű C# konzolos alkalmazás, aminek a feladata a szenzorok mérési naplóinak beolvasása és kiértékelése. 
A projektet referenciának készítettem, hogy bemutassam a gyakorlatias programozási alapjaimat.

# Funkciók
* Adatok beolvasása: Szöveges fájlokból (.txt vagy .csv) olvassa ki a sorokat.
* Hibakezelés: Biztonságosan alakítja a szöveget számmá. Ha a fájlban véletlenül hibás adat van (pl. betű szám helyett), a program a try-catch megoldásnak köszönhetően nem fagy le, hanem jelzi a hibát.
* Határérték ellenőrzés: Megvizsgálja, hogy a mért értékek a megadott alsó és felső határokon belül vannak-e.
* Statisztika: A futás végén összegzi, hogy mennyi volt a jó mérés, a selejt (határértéken kívüli), és az érvénytelen adat.

# Használt technológiák
* C# programozási nyelv
* Alapvető fájlkezelés (File I/O)
