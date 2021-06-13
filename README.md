# bar.io

<img align="middle" src="https://github.com/BobanNikolov/bar.io/blob/main/bar.io_logo.png" alt="bar.io logo" width="500" height="500" />

> Во продолжение следува документацијата за проектната задача по Визуелно Програмирање 2020/2021

---

### Содржина

- [Објаснување на проблем](#објаснување-на-проблем)
- [Опис на решение](#решение)
- [Опис на изворен код](#изворен-код)
- [Изглед на апликацијата и упатство за користење](#изглед-и-упатство)
- [Информации за авторите](#информации-за-авторите)

---

## Објаснување на проблем

Проблемот кој се решава со апликацијава е доста секојдневен. Имено, станува збор за регулирање на работата на едно кафуле. Во кафулето ја покриваме работата на менаџери, келнери и шанкери. 
Менаџерите имаат за задача да внесуваат артикли со кои што располага кафулето, да прегледуваат дневна сметка за работата на кафулето и да регулира резервации. 
Келнерите имаат за задача да услужуваат гости во кафулето. За да биде искуството комплетно, келнерите имаат за можност да додаваат маса која што ја служат, да уредуваат претходно додадена маса, да избришат претходно додадена маса и да извадат сметка за селектирана маса.
Шанкерите имаат наједноставна задача. Едноставно, тие треба да гледаат нарачани артикли од страна на келнерите и да ги потврдуваат како испорачани.

[Врати се горе](#bar.io)

---

## Решение

За да се реши проблемот, користиме голем број на класи и форми со кои што ја регулираме функционалноста на системот. Користиме класи за секоја засегната страна и соодветно за нивно поврзување. Во продолжение ќе бидат детално објаснети истите. За полесно и поефективно снаоѓање при кодирање на апликацијата користевме FACTORY DESIGN PATTERN.

### Менаџер

Во класата за менаџер се чуваат податоци за името на менаџерот, неговото корисничко име за најава и автоматски генерираната лозинка за најава во системот.

### Келнер

Во класата за келнер се чуваат податоци за името на келнерот, неговото корисничко име за најава и автоматски генерираната лозинка за најава во системот, како и листа од маси кои што ги служи.

### Шанкер

Во класата за шанкер се чуваат податоци за името на шанкерот, неговото корисничко име за најава и автоматски генерираната лозинка за најава на системот, како и листа од нарачки кои ги има добиено од келнерите.

### Маса

Во класата за маса се чуваат: id-то на масата, слободните места за седење на неа и нарачка која што ја има конкретната маса. Соодветно имаме toString() метод.

### Нарачка

Во класата за нарачка се чуваат: име на кое што се води нарачката, податок дали е активна или не и речник во кој што клуч е артикал, а вредности се количината колку артикли биле порачани. Соодветно имаме toString() метод и update функција на порачаните артикли која што се повикува при секоја промена на нарачани/испорачани артикли.

### Артикал

Во класата за артикал се чуваат податоци за името на артиклот и цената на истиот. Соодветно имаме toString() метод.

### Резервација

Во класата за резервација се чува името на кое што се води резервацијата и маса која е резервирана. Соодветно имаме toString() метод.

### Корисници 

Во класата за корисници се чуваат листи од сите корисници. Соодветно имаме листа од менаџери кои работат во кафулето, листа од келнери и листа од шанкери. Во оваа класа имаме get-ери и функции за проверка на лозинката.

### Локал

Во класата за локалот се чуваат сите ресурси со кои располага кафулето. Овде имаме 3 речници, и тоа: речник за резервации, во кои што за секој различен ден се чува листа од резервации; речник за слободни маси, во кои што за секој различен ден се чува листа од слободни маси; речник за артикли со кои располага кафулето, во кои што за секој артикал имаме количина за тоа колку артикли има во кафулето.

Понатаму решението се сведува на повеќе форми, каде секоја си има своја функционалност и во која што се користат голем број на функции и помошни променливи за да се добие посакуваниот ефект. 

[Врати се горе](#bar.io)

---

## Изворен код

```csharp
    public class Lokal
    {
        public static Dictionary<string, List<Rezervacija>> Reservations { set; get; }
        public static Dictionary<string, List<Masa>> AvailableTables { get; set; }
        //(10) { new Sanker("Goran"), new Sanker("Zoran"), new Sanker("Vane"), new Sanker("Ivan") };
        public static Dictionary<Artikal, int> Artikli = new Dictionary<Artikal, int>{ {new Artikal("Coca-Cola",20),10 }, { new Artikal("Sprite", 20), 10 } , { new Artikal("Fanta", 20), 10 }, { new Artikal("Malo Makijato", 20), 10 }, { new Artikal("Golemo Makijato", 20), 0 } };
        public Lokal()
        {
            Reservations = new Dictionary<string, List<Rezervacija>>();
            AvailableTables = new Dictionary<string, List<Masa>>();
            
        }
        public static List<Artikal> getArtikli()
        {
            List<Artikal> artikli = new List<Artikal>();
            if (Artikli!=null)
            {
                foreach (var a in Artikli.Keys)
                {
                    artikli.Add(a);
                }
            }
            return artikli;
        }
    }
```

Овде е прикажан кодот за класата Локал, во која како што кажавме погоре дека се чуваат податоци за резервации, слободни маси и артикли распоредени по речници. Поставуваме иницијални вредности во речникот за артиклите со цел да имаме ресурси со кои може да манипулираме при кодирање на апликацијата. Во продолжение имаме конструктор во кој имаме иницијализација само на речниците за резервации и слободни маси, бидејќи за артиклите имаме веќе поставено иницијални вредности. Понатаму е прикажан кодот за преземање на артикли во кој имаме помошна листа од артикли која ја полниме со артикли кои што го има во кафичот и ги праќаме онаму каде што се потребни.

[Врати се горе](#bar.io)

---

## Изглед и упатство

### Изглед на почетната страна

<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/pocetna.jpg" width=600 height=400>

### Изглед на најавите за менаџерот, келнерот и шанкерот

<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/najava_menadzer.jpg" width=300 height=400> <img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/najava_kelner.jpg" width=300 height=400> <img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/najava_sanker.jpg" width=300 height=400>

### Изглед на формите за работа на менаџерот

<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/pocetna_menadzer.jpg" width=300 height=400> <img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/izberi_den.jpg" width=300 height=300>
<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/vnesi_rezervacija.jpg" width=600 height=400>
<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/dodadi_rezervacija.jpg" width=300 height=250>
<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/dodadi_artikal.jpg" width=300 height=300>

### Изглед на формите за работа на келнерот

<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/pocetna_kelner.jpg" width=600 height=400> <img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/dodadi_masa.jpg" width=300 height=250>
<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/dodadi_naracka.jpg" width=600 height=380> <img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/vnesi_lozinka.jpg" width=350 height=250>

### Изглед на формите за работа на шанкерот

<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/pocetna_sanker.jpg" width=600 height=500>
<img src="https://github.com/BobanNikolov/bar.io/blob/main/sliki-bar.io/isporacaj_naracka.jpg" width=350 height=250>

[Врати се горе](#bar.io)

---

## Информации за авторите

- Бобан Николов - 191199 - https://github.com/BobanNikolov
- Горјан Мицевски - 191204 - https://github.com/gorjanmicevski
- Бојан Радевски - 194009 - https://github.com/BojanRadevski

[Врати се горе](#bar.io)

---
