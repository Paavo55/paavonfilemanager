Tällä hetkellä sovellus on vain tiedosto selain jossa ei ole monia hyödyllisiä ominaisuuksia.

![filemanager1](https://github.com/Paavo55/paavonfilemanager/assets/151019834/f311869f-9526-4448-b4fe-0f3884ee06f2)
![filemanager2](https://github.com/Paavo55/paavonfilemanager/assets/151019834/142a91c9-3a1b-4e97-84ef-5dca3b71f2eb)
Koodissa on kaikille napeille annettu tiedosto jonka ne avaavat ja DisplayFiles kooodi luo tiedostoista listan ja antaa niille omat napit ohjelmaan.
Back nappi muistaa viimeisen tiedoston jossa oltiin ja palaa tähän jos mahdollista.

Parannuksia olisi että back nappi toimisi aina ja oikein.

Ohjelmaan voisi myös tehdä hakupalkin ja mahdollisesti tiedostonluomisen mahdollisuuden.

<img width="491" height="186" alt="koodi" src="https://github.com/user-attachments/assets/600a67df-b18a-477b-a221-edd111292ff4" />

Back napin koodi. Appi muistaa aikaisemman sivun jolla olet ollut ja tallentaa sen navigationHistory muuttujaan ja jos se on suurempi kuin 1, se poistaa tämän hetkisen sivun. 
Tämän jälkeen previousFolder muuttujalle annetaan navigationHistorystä tämän hetkinen arvo ja avataan arvon mukainen sivu. 


Vuokaavio:
<img width="649" height="188" alt="vuokaavio" src="https://github.com/user-attachments/assets/204810b6-dc1c-4514-8dbe-b0c8ddf8df69" />
