# O hre "Escape Room"
Naša hra by bola zameraná na edukáciu v oblasti algoritmov a programovania čo znamená, že začiatočníci a deti by sa oboznámili so základnými algoritmami, technikami a štruktúrami v programovaní a tí pokročilí by si prehĺbili už nadobudnuté skúsenosti. Hra by mala zabudované skóre, tým pádom by sa hráč vedel posúvať v nejakom rebríčku čím ďalej tým vyššie.

Hráč by sa na začiatku hry ocitol náhodne vygenerovaný v labyrinte, ktorý by bol zložený zo stien. Cieľom hry je vyskladať správny algoritmus za obmedzený čas tak, aby sa postavička dostala bezpečne do ďalšieho levelu – pohyb by nebol riešený cez W A S D či šípky, ale algoritmicky.

Nebude to však také jednoduché ... na začiatku bude mať hráč pomerne dosť času premýšľať a vyskladať správny algoritmus z vopred definovaných možností aby sa dostal z bludiska a musel by čeliť rôznym prekážkam (jamy, pohybujúce sa steny, …) Ak sa ale rozhodne, že zapne tzv. hardcore mód tak čím bude ale vo vyššom leveli, tým bude náročnosť algoritmu zložitejšia a čas kratší. 

Prijmete našu výzvu zdolať náš algoritmický labyrint a dostať sa na koniec?

## Príklad správneho algoritmu pre únik z labyrintu
```
Start
Turn(right, 270)
For(int i = 0; I < 5; i++)
{
   Go(forward)
}
Turn(left,90)
End
```
