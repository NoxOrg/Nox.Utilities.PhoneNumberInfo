
namespace Nox.Utilities.PhoneNumberInfo;

public static partial class PhoneNumberExtensions
{
        private static readonly string[] _carriers = new string[] {
            "019mobile",
            "0700 LTD",
            "08Direct",
            "09 Mobile",
            "21Vianet",
            "24 Seven",
            "2Day Telecom",
            "2degrees",
            "3",
            "3 Italia",
            "3ton s.r.o.",
            "42 telecom ab",
            "4ka of SWAN",
            "9mobile",
            "A1",
            "A1 TA",
            "A1 Telekom",
            "Aazad distribution discretionary trust",
            "Ace Call",
            "A-Cell",
            "ACN Communications",
            "ACN Communications Sweden",
            "ADIE",
            "Affordable Island Communications",
            "Afghan Telecom",
            "Afone",
            "Africell",
            "Africell Angola",
            "AGILE TELECOM POLAND",
            "AinaCom",
            "Airbus Defence and Space",
            "Aircel",
            "Aire Networks",
            "Airnet New Zealand NOW",
            "AirSom",
            "Airtel",
            "airteltiGO",
            "Airwave",
            "AIS",
            "Aktel",
            "Al Hourria Telecom",
            "Alai",
            "ALBtelecom",
            "Alfa",
            "Alfa iletisim",
            "ALFA Telecom",
            "aliv",
            "Alliance",
            "Alltele Sverige",
            "Al-Madar",
            "Alphalink",
            "Altavox",
            "Altecom",
            "Altel",
            "Alternet, s.r.o.",
            "altibox",
            "Amcatel",
            "AMD Telecom",
            "AMD Telecom S.A.",
            "AMSUK",
            "AMT",
            "Amtel",
            "Andrews & Arnold",
            "Annatel",
            "Antares",
            "Antel",
            "Antelecom",
            "Anywhere Sim",
            "Apex Telecom",
            "Apifon",
            "APUA",
            "aql",
            "Areeba",
            "Argon Networks",
            "Arna",
            "Asanet",
            "Asiacell",
            "Asia-Pacific Telecom",
            "ASPIDER Solutions Nederland B.V.",
            "Assistant Telecom",
            "ASTCA",
            "AT&T",
            "AT&T Cingular Wireless Network",
            "Atel",
            "ATHKL",
            "Avantel",
            "AWCC",
            "AWS Grenada",
            "Axfone",
            "Axialys",
            "AXIS",
            "Azercell",
            "Aztelekom",
            "Babilon-M",
            "Bahnhof AB",
            "Bakcell",
            "Banglalink",
            "Baraka",
            "BaTelCo",
            "BaTelCo",
            "BebbiCell AG",
            "Beeline",
            "Beeline Telecoms",
            "BeeOne Communications",
            "Beepsend",
            "beepsend ab",
            "Beezz",
            "Belcel",
            "Belink Spa.",
            "Belize Telemedia Ltd (Digi)",
            "Bellingham",
            "benemen lso (tdc)",
            "Benemen Oy",
            "Benson Informatics",
            "Best Telecom",
            "BH Telecom",
            "BITĖ",
            "Bite Latvia",
            "BIZTELCO SVERIGE AB",
            "BJT",
            "BLK",
            "Blue Sky",
            "Blue Two",
            "Blueline",
            "BluePhone",
            "Bluesky",
            "BlueWave Communications",
            "BM Sverige AB",
            "bmobile",
            "B-Mobile of Bhutan Telecom",
            "Bob",
            "Borderlight",
            "Boutique",
            "Bouygues",
            "Brasil Telecom GSM",
            "Bredband 2",
            "BSG",
            "BSG Estonia",
            "BSG ESTONIA OU",
            "BSNL MOBILE",
            "BT",
            "BT OnePhone",
            "BTC Mobile",
            "BWS",
            "C&W",
            "Cable & Wireless",
            "Callplus",
            "Camtel",
            "CardBoardFish",
            "care solutions aka phone-it",
            "CariGlobe St. Kitts",
            "CARITAS",
            "Carphone Warehouse Ireland Mobile Limited",
            "Carrefour",
            "Carrier Enabler",
            "cbb mobil",
            "CBN",
            "CCT",
            "Celcom",
            "Celecom",
            "Cell C",
            "Cellact",
            "Cellcard",
            "Cellcom",
            "CELLIP AB",
            "Cellplus",
            "Cellpluss Spa.",
            "Cellran Cellular Communications",
            "Cellular One",
            "Celtel (Tigo)",
            "Celupago",
            "CENTENNIAL",
            "Center 2M",
            "CESG",
            "Cesky bezdrat",
            "CEZ Group",
            "CFL",
            "Changi Travel Services Pte Ltd",
            "Cheers",
            "Chile.Com",
            "chilimobil",
            "China Mobile",
            "China Telecom",
            "China Telecom (France) Limited",
            "China Telecom Global Limited (CTG)",
            "China Unicom",
            "China-Hongkong Telecom",
            "Chinguitel",
            "Chippie",
            "Choice Phone",
            "Chunghwa Telecom",
            "Cibeles Telecom",
            "CITIC",
            "Citrus",
            "Citycell",
            "Claro",
            "Cloud9",
            "clx networks ab",
            "CNT",
            "Com Hem",
            "com4",
            "COMA",
            "Comfone AG",
            "Comium",
            "Comores Telecom",
            "Compania Chilena De Comunicaciones Parallel S.A.",
            "Compania De Telecomunicaciones De Chile S.A.",
            "Compania De Teléfonos De Coyhaique S.A.",
            "Compatel",
            "Compatel Chile Limitada",
            "compatel limited",
            "Complejo Manufacturero De Equipos Telefonicos S.A.C.I.",
            "Completel",
            "Comunicacion Y Telefonia Rural S.A.",
            "Comunicaciones Dime",
            "Confabulate",
            "Congo telecom",
            "Connectel AB",
            "Convergia Telecom S.A.",
            "COOLTEL APS",
            "CooTel",
            "Core Communication",
            "Core Telecom",
            "Coriolis Telecom",
            "Cosmote",
            "CSTmovel",
            "CTM",
            "Cubic",
            "Cuuma",
            "CVMOVEL",
            "CWS",
            "Cyta",
            "Cytamobile-Vodafone",
            "Dani CALL",
            "Darkhan Telecom",
            "Datacom",
            "DataHouse Global",
            "Dauphin Telecom",
            "Deion",
            "Deltronics",
            "Devoli",
            "Dhiraagu",
            "DIA",
            "Diabolocom",
            "Dial Telecom",
            "Dialog",
            "Dialogue Communications",
            "DIGI",
            "Digi Communications",
            "Digi Mobil",
            "Digicel",
            "Digicel Antilles Francaises Guyane",
            "Digicel Bermuda",
            "Digicel Grenada",
            "Digicel Guyana",
            "Digicel Honduras",
            "DigiMobil",
            "Digitel",
            "Digitel GSM",
            "DIGIVOIP",
            "Dimoco",
            "Dito",
            "Djezzy",
            "DNA",
            "Dolphin Telecom",
            "Dragon Internet",
            "Drillisch Online",
            "DSTCom",
            "DTAC",
            "du",
            "Duru Telekom",
            "e*Message",
            "Easy Telecom AB (BILDNINGSAGENTEN 559)",
            "Easy World",
            "Econet",
            "Econet Ezi-Cel Lesotho",
            "EE",
            "Eircom",
            "Elemte-Invest",
            "Elisa",
            "ellipso satellite",
            "eMobile",
            "Empresas Bunker S.A.",
            "Emtel",
            "Enabling Asia",
            "Enigma-System",
            "Entel",
            "epic",
            "Eplus",
            "Eplus/Sipgate",
            "Eplus/Telogic",
            "Equateur Telecom",
            "erate",
            "Ericsson NV",
            "EriTel",
            "Esendex",
            "etecsa",
            "Ethio Telecom",
            "Etisalat",
            "ETL",
            "EU Tel AB",
            "Euroinformation Telecom",
            "Eurona",
            "Euskaltel",
            "Evatis",
            "Expresso",
            "EZ PHONE MOBILE",
            "FarEasTone",
            "Faroese Telecom",
            "Fast Communication",
            "FAYN Telecommunications",
            "Febo Telecom",
            "Fibio Nordic AB",
            "FINK TELECOM SERVIC",
            "Finserve",
            "firmafon",
            "First Mobile",
            "firstcom",
            "flexfone",
            "FleXtel",
            "Fogg",
            "FONEX",
            "FONIA AB",
            "Foniv Telecommunications Services",
            "Forthnet",
            "Fractel",
            "Free Caraibe",
            "Free Caraïbe",
            "Free Mobile",
            "Free Telecom",
            "FSM Telecom",
            "FSMTC",
            "Fullcom S.A.",
            "fullrate",
            "Gamcel",
            "Gamma Telecom",
            "Gateway Communications",
            "Gazprom Telekom",
            "Geenet",
            "Gemtel",
            "Generic Mobil Systems",
            "GETESA",
            "Gibfibre",
            "GibTel",
            "gigsky aps",
            "GIGSKY Mobile",
            "Glo",
            "Global Telecom",
            "Global Telefoni Sve",
            "Globalcell",
            "Globally Advanced Integrated Networks Ltd",
            "GlobalReach",
            "globalstar",
            "Globalstar Europe",
            "GLOBALTEL",
            "Globe",
            "Globecom",
            "GLOBETOUCH AB",
            "GLONASS",
            "Glotell B.V (V-Tell NL)",
            "G-Mobile",
            "GMPCS",
            "GO Mobile",
            "Golan Telecom",
            "Golis Telecom",
            "GoMobil",
            "GoMobile",
            "GOPE Systems a.s.",
            "Gotalandsnatet",
            "Grameenphone",
            "GTA",
            "Gtd Manquehue S.A.",
            "Gtd Telesat S.A.",
            "Guangxing Communication Co",
            "Guinetel",
            "Guyana Telephone and Telegraph Company",
            "Halys",
            "Hamilton Telecom",
            "Handy",
            "Hanhaa",
            "HATNET BILGI ILETISIM TEKNOLOJILERI",
            "ha-vel internet",
            "HAYO",
            "herobase",
            "HI3G Access",
            "HKT",
            "Home Cellular",
            "Home Office",
            "Homeland Media",
            "HONDUTEL",
            "Hong Kong Broadband Network",
            "HORISEN AG",
            "Hormuud",
            "Hot Mobile",
            "Hrvatski Telekom",
            "HSL",
            "HT ERONET",
            "Hutch",
            "Hutchison Drei Austria",
            "i CAN_GSM",
            "ice danmark",
            "ice norge",
            "icentrex lso(tdc)",
            "iCentrex Sweden AB",
            "ico satellite",
            "Icron Network",
            "ID Mobile",
            "IDC",
            "Idea",
            "Ifx Networks Chile S.A.",
            "IM Consulting Izabela",
            "Imam Hussien Holy Shrine",
            "IMC",
            "iMEZ",
            "In&Phone",
            "Indochina Telecom",
            "Indosat Ooredoo Hutchison",
            "Industel Chile Ltda",
            "InfoVOIP",
            "Infura",
            "Ingenium Outsourcing Services Chile Spa.",
            "INNOVAC",
            "Instaphone",
            "intelecom",
            "Intelfon",
            "Intelvision",
            "Inter Telecom",
            "Interactive Digital Media",
            "Interactive Digital Media GmbH",
            "Intercall",
            "Intercel",
            "Intermatica",
            "Internod",
            "Intersvyaz-2",
            "Intertelecom",
            "Inversiones Santa Fe Ltda.",
            "Inwi",
            "Ion mobile",
            "IP Directions",
            "IPEX",
            "IPfon, s.r.o.",
            "IPIFY LIMITED",
            "IPKO",
            "ipnordic",
            "IP-Only Telecommunication",
            "IPTEL",
            "IPV6",
            "ipvision",
            "Irancell",
            "IraqTel",
            "iridium satellite",
            "Iristel",
            "IR-MCI",
            "Islandcom",
            "Isnet",
            "ITC Fanoos",
            "Itisaluna",
            "ITPC",
            "IV Response",
            "Jawwal",
            "jay.net",
            "Jetnet",
            "JMDI",
            "JOIN",
            "Join Experience Belgium",
            "JT",
            "JTL",
            "JUNYVERSE AB",
            "Kalimat",
            "Katel",
            "Kav El International",
            "Kcell/Activ",
            "KDDI",
            "Keyyo",
            "KKTC Telsim",
            "Kla",
            "Kolbi ICE",
            "Korek",
            "Koryolink",
            "KPN",
            "KPTC",
            "KT",
            "K-Telecom Ltd",
            "Kulan",
            "Kuzey Kibris Turkcell",
            "kvantel",
            "KW Telecommunications",
            "Kyivstar",
            "La poste telecom",
            "Lancelot",
            "Lancelot Telecom",
            "Lanonyx",
            "Lao Telecom",
            "Lebara",
            "Lebara France Limited",
            "lebara limited",
            "LegendTel",
            "Legos",
            "Lemontel",
            "Lemonvil",
            "Leo",
            "LG U+",
            "Liberia Telecom",
            "Libertis",
            "Libre Tecnologias",
            "Libya Telecom & Technology",
            "Libyana",
            "life:)",
            "lifecell",
            "Liffey Telecom",
            "Liikennevirasto",
            "LIME",
            "Limitless",
            "link mobile",
            "Link Telecom",
            "Linksat Comunicaciones Spa.",
            "Lleida.net",
            "LMT",
            "Logic Communications",
            "Lonestar Cell",
            "LOTUSTEL",
            "LOXYTEL AB",
            "Lyca Mobile",
            "Lycamobile",
            "lycamobile denmark ltd",
            "Lycamobile Sweden",
            "m:tel",
            "M1",
            "MAFAB",
            "Magrathea",
            "MagtiCom",
            "Magyar Telekom",
            "Maingate (Sierra Wireless)",
            "Malawi Telecom-munications Ltd (MTL)",
            "Manx Telecom",
            "Marathon Telecom",
            "Maritime Communications Partner (MCP)",
            "Maroc Telecom",
            "Mars",
            "Mascom",
            "Maskyoo",
            "MasMovil",
            "MATERNA Communications",
            "Mattel",
            "Mauritel",
            "Mavi",
            "Maxis",
            "MAXPROGRES",
            "maxtel.dk",
            "mcel",
            "Mediatel",
            "Méditel",
            "Medium Telecommunications Services",
            "MegaFon",
            "Melita Mobile",
            "MEO",
            "MERCURY INTERNATIONA",
            "MessageBird",
            "MESSAGEBIRD B.V.",
            "MessageBird BV",
            "Meteor",
            "Metfone",
            "METRONET",
            "MI",
            "MI Carrier Services",
            "miniTEL",
            "MINITEL AB",
            "MIO Wireless",
            "mitto ag",
            "Mobicom",
            "MobiFone",
            "Mobik",
            "Mobiland",
            "Mobile Arts AB",
            "Mobile FX Services Ltd",
            "Mobile One",
            "Mobile Pay",
            "Mobile Vikings/JIM Mobile",
            "Mobiledata Sp. z o.o.",
            "Mobilink",
            "Mobilis",
            "Mobilisim Mobil Bilisim",
            "Mobility",
            "Mobilphone",
            "Mobily",
            "Mobiquithings",
            "Mobitel",
            "MobiUZ",
            "MobiWeb",
            "mobiweb limited",
            "MOBIWEB LTD",
            "Mobiweb telecom limited",
            "Moldcell",
            "Moldtelecom",
            "Monaco Telecom",
            "MONTY UK GLOBAL LIM",
            "monty uk global limited",
            "MONTYHO TECHNOLOGY s.r.o. (CANISTEC)",
            "Moov",
            "Motiv",
            "Motto",
            "Move Telecom S.A.",
            "Movicel",
            "Movil Exito",
            "Movilnet",
            "Movistar",
            "Movitel",
            "MPT",
            "M-STAT",
            "MTC",
            "MTCE",
            "MTML",
            "MTN",
            "MTN Cameroon",
            "MTNL",
            "MTS",
            "MTS (BARASH Communication)",
            "mts d.o.o.",
            "Multibyte",
            "Multiconnect",
            "Multilinks",
            "Multiregional Transit Telecom (MTT)",
            "mundio mobile",
            "Muni",
            "MVM Net",
            "My Number",
            "MyPhone",
            "myrepublic",
            "Mytel",
            "N.M.B.S.",
            "NÃ³made Telecomunicaciones",
            "NAKA AG",
            "Nar Mobile",
            "Nat Nat Bai Holding",
            "Natcom",
            "National Security",
            "National Telecommunications Authority",
            "Nationlink",
            "Nationwide Telephone",
            "Naxtel",
            "NCell",
            "NDCL",
            "Nepal Telecom",
            "Neptune Communications",
            "Net*One",
            "NetCom",
            "Netcom Group",
            "Netel S.A.",
            "NETETT SVERIGE AB (AINMT Sverige)",
            "Netfone Telecom",
            "netfors unified messaging",
            "Netglobalis Telecom S.A.",
            "Netgsm",
            "Nethits",
            "Netline",
            "NETMORE GROUP AB",
            "NETTIA",
            "Network of the World",
            "Network of The World Ltd",
            "Nexphone",
            "NextGen Mobile / CardBoardFish",
            "nextgen mobile ldt t/a cardboardfish",
            "nextgentel",
            "NEXTTEL",
            "Nida Telekomunikasyon",
            "Niger Telecoms",
            "NIMBUSFIVE GmbH",
            "nkom (nasjonal kommunikasjonsmyndighet)",
            "Nodemax",
            "Nokia",
            "Nokia Solutions and Networks",
            "Nord Connect SIA",
            "Nordic Telecom s.r.o.(Air Telecom - MobilKom)",
            "Nordnet",
            "Norfolk Telecom",
            "Nortech",
            "NOS",
            "Nova",
            "Novatel",
            "NOWO",
            "NRG Media Limited",
            "NSTPL",
            "Ntel",
            "NTT Docomo",
            "Nuevatel",
            "Nur Telecom",
            "Nursat",
            "O2",
            "Ocean Link",
            "Oceans",
            "Oi",
            "Omantel",
            "Omnnea",
            "O-Mobile",
            "Onatel",
            "ONDO",
            "ONITELECOM",
            "Onlime",
            "Only",
            "Only (Telco OI)",
            "Onoff telecom",
            "ONOFF TELECOM SAS",
            "OnOff Télécom SASU",
            "onoffapp",
            "Onvoy",
            "Ooredoo",
            "Ooredoo Group",
            "OpenMovil",
            "Ops Ingenieria Ltda.",
            "Optic Telecomunicaciones Ltda.",
            "OPT-NC",
            "Optus",
            "Orange",
            "Orange AT",
            "Orange France",
            "Oration Technologies",
            "ÖRETEL AB",
            "Origines",
            "Öryggisfjarskipti",
            "OSE",
            "OTE",
            "OTEGlobe",
            "OUTREMER TELECOM",
            "Oxygen8",
            "Ozone",
            "Pacifico Cable S.P.A.",
            "Packcet One",
            "PalauCel",
            "PalauTel",
            "Palestine Cellular Communications",
            "Parlem",
            "Partners Telecom Colombia",
            "Pasifik Telekom",
            "Pelephone",
            "Pelicell Telecommunications",
            "Penguin SIM",
            "PEOPLEnet",
            "PepePhone",
            "Perfectum",
            "Personal",
            "phonect",
            "Phonegroup",
            "Pivotel Satellite",
            "PKP Polskie Linie Kolejowe S.A.",
            "Play",
            "Plus",
            "Plus4U Mobile s.r.o.",
            "PMCI",
            "PODA a.s. (SkyNet)",
            "polperro",
            "Polska Spoka Gazownictwa Sp",
            "POST",
            "Premium Net International",
            "Premium Net International SRL",
            "Premium O",
            "Prestel",
            "PrimeTel",
            "Private Mobility Nederland",
            "Prixtel",
            "Progresif Cellular",
            "Promobile",
            "Pronto Ip Ltda.",
            "Proximus",
            "PTI PACIFICA",
            "PTV",
            "Qall Telecom AB",
            "qbmore/Cadcomms",
            "QCell",
            "Quantax",
            "Quattre",
            "QX Telecom",
            "R",
            "Rail Corporation NSW",
            "Rakuten Communications",
            "Rami Levy",
            "REACH",
            "Rebtel Networks",
            "Red Bull Mobile",
            "red ONE",
            "Reddi",
            "Redvoiss",
            "Relario AG (Bebbicell)",
            "Reliance Jio",
            "Republica Movil",
            "Resilient",
            "REWICOM SCANDINAVIA",
            "Rightel",
            "Robi",
            "Roitel",
            "Roshan",
            "Royal Court",
            "Rural Telecommunications Chile S.A.",
            "S TEL",
            "SabaFon",
            "Safaricom",
            "Salam",
            "Salt",
            "Sarenet",
            "Satel",
            "Satsol",
            "SAZKA sazkova kancelar, a.s",
            "Sberbank-Telecom",
            "SBIN",
            "SCT",
            "Seatel",
            "Sema Mobile",
            "Sercom (Claro)",
            "Service des Postes et Télécommunications",
            "Servicios Internet Limitada",
            "SETAR",
            "Setroc Mobile",
            "Sevastopol TELECOM",
            "Sewan communications",
            "SFR",
            "SFR/Rife",
            "Shatel Mobile",
            "SIA Net Balt",
            "SIA NETBALT",
            "SIA Ntel Solutions",
            "sierra wireless",
            "Sierratel",
            "Silknet",
            "Sim Telecom",
            "Simba",
            "Síminn",
            "simservice",
            "Simwood",
            "SingTel",
            "SKTellink",
            "Sky",
            "Sky mobile",
            "Skytel",
            "Sloexport",
            "Slovak Republic Railways (GSM-R)",
            "Smart",
            "SMART Comp",
            "Smart Mobile",
            "Smart Telecom",
            "Smartfren",
            "SmarTone",
            "Smile",
            "SMS Provider Corp",
            "SMSHIGHWAY LIMITED",
            "SMSRelay AG",
            "Soatso AB",
            "Sociedad Comercial y de IngenierÃ­a Swedcom",
            "Sociedad Falabella Movil Spa.",
            "Softbank",
            "Softelnet S.A. Sp. k.",
            "SoftNet",
            "Solomon Telekom",
            "SOLUNO BC AB",
            "Somali Networks",
            "SomNet",
            "Somtel",
            "Sonet",
            "Soracom",
            "Sotel",
            "Sotelgui",
            "Sotelma",
            "Soul Pattinson",
            "Spacetel",
            "Spark",
            "Special Communications Organization",
            "Speednet (Smart)",
            "SPINBOX AB",
            "SPIRIUS AB",
            "SPM Telecom",
            "Sprint",
            "SPTC",
            "SST Net Sverige AB",
            "Starcomms",
            "StarHub",
            "STC",
            "Stel Access S.A.",
            "STG",
            "STM Telecom",
            "Stour Marine",
            "Sudatel",
            "Sudatel Group",
            "Suma Movil",
            "Sumamovil Portugal",
            "Sun Mobile",
            "Sunbeach Communications",
            "SunCom Wireless Puerto Rico",
            "Sunrise",
            "Suomen Virveverkko",
            "supertel danmark",
            "Sure",
            "Sure (Guernsey) New Zealand Limited",
            "Sure Ltd",
            "Sure South Atlantic",
            "Sure South Atlantic Limited",
            "Sure South Atlantic Ltd",
            "Sure Telecom",
            "svea billing services",
            "Svea Billing System",
            "SVENSK KONSUMENTMOBI",
            "svr technologies (mach connectivity)",
            "Swazi Mobile Ltd",
            "Swazi MTN",
            "SWEDFONENET AB",
            "Swiftnet",
            "Swisscom",
            "Syma",
            "Syma mobile",
            "Symbio Networks",
            "Symbio Networks PTY",
            "Synectiv",
            "Syriatel",
            "SŽ - Infrastruktura",
            "T Star",
            "T+",
            "T-2",
            "Tacom",
            "Taiwan Mobile",
            "Taliya",
            "TalkTalk",
            "Tangerine",
            "Tango",
            "Tanzania Telecom",
            "TARR",
            "TashiCell of Tashi InfoComm",
            "Tata Docomo",
            "Tcell",
            "tdc",
            "TDF",
            "TE",
            "TelAfrica (Wirles Connect)",
            "telavox",
            "Telavox AB",
            "Telcell",
            "TELCO",
            "TELCO LEADERS LTD",
            "TelcoVillage",
            "Tele 2",
            "TELE Greenland A/S",
            "tele.ring",
            "Tele2",
            "Tele2 Sverige",
            "Telecable",
            "Telecel",
            "Telecel Faso",
            "Telecom 10",
            "Telecom Cambodia",
            "Telecom Italia San Marino",
            "Telecom Liechtenstein",
            "Telecom Namibia",
            "Telecom Niue",
            "Telecom Vanuatu Ltd",
            "telecom x",
            "Telecom2",
            "Telecom26 AG",
            "Telecom3 Networks",
            "Telecoms Cloud",
            "Telecomunicaciones Dotcom",
            "Telecomunicaciones Max Ltda.",
            "Telecomunicaciones Net Uno Ltda.",
            "Teleena",
            "Teleena (MVNE)",
            "TelefÃ³nica Uno Uno Cuatro",
            "Telefocus",
            "Telefonica Del Sur S.A.",
            "Telefónica Móviles",
            "Telefonica O2",
            "Telekabel",
            "TeleKish",
            "Telekom",
            "Telekom Slovenije",
            "Telekom Srbija a.d.",
            "Telemach",
            "Telemig Celular",
            "TELENABLER",
            "Telenet",
            "Telenor",
            "Telenor Connexion",
            "telenor norge",
            "Telenor Sverige",
            "Telesign",
            "Telesom",
            "Telestar",
            "TELESTRADA S.A.",
            "Telesur",
            "Telet Research",
            "TeleTalk",
            "Teletok telecommunications",
            "Television Interactiva",
            "TeleWare",
            "Telewings",
            "Telfort",
            "Telgua",
            "Telia",
            "Telia Eesti AS",
            "telia telecom solution",
            "TeliaSonera",
            "TELIGOO AB (Fello AB)",
            "Telkom",
            "Telkom Mobile",
            "Telkomcel",
            "Telkomsel",
            "TELL ESS AB",
            "Telma",
            "Telna",
            "TELNESS AB",
            "Telstra",
            "telus aps",
            "TERMS",
            "Tesacom",
            "Tesco Mobile",
            "Tesco Mobile CR",
            "Test2date",
            "TGL",
            "Three",
            "thyfon",
            "Tigo",
            "TIM",
            "Timor Telecom",
            "Tismi",
            "TISMI BV",
            "TM-Cell",
            "T-Mobile",
            "T-Mobile (Slovak Telekom)",
            "T-Mobile AT",
            "T-Mobile Thuis",
            "TMT",
            "TN Mobile",
            "TNM",
            "TOGOCEL",
            "Toko Wireless",
            "Top Connect OU",
            "TOT Mobile",
            "Touch",
            "Transatel",
            "TRAVEL TELEKOMMUNIKATION",
            "TravelSIM",
            "Triatel",
            "Tribe Mobile Chile Spa",
            "Tricom",
            "TriMob",
            "tripple track europe",
            "True Move",
            "Truphone",
            "TT Quality s.r.o.",
            "TTM",
            "Tune Talk",
            "Tunisie Telecom",
            "Turk Telekom",
            "Turkcell",
            "Tuvalu Telecom",
            "Twilio Ireland Limited",
            "U Mobile",
            "U-Call Tonga",
            "Ucell",
            "Ucom",
            "Uff!",
            "Ufone",
            "UK Broadband",
            "Umniah",
            "Unicorn Telecom",
            "Uninor",
            "UNISTARS",
            "Unitel",
            "uni-tel",
            "UPC",
            "UPC Polska",
            "UPC Switzerland",
            "UTL",
            "UTS",
            "UTS CARAIBES",
            "Uzbektelecom",
            "Vainakh Telecom CJSC",
            "vala",
            "Vectone",
            "Vectone Distribution Czech Republic s.r.o(Mundio)",
            "Vectone mobile",
            "Vectone Mobile Limited (Mundio)",
            "Vectone Mobile/Delight Mobile",
            "Velcom",
            "Ventelo Sverige",
            "Veon",
            "Viatel Sweden",
            "Victorian Rail Track",
            "Vidanet",
            "Vietnamobile",
            "Viettel",
            "Viettel (Telemor brand)",
            "Viettel Mobile",
            "Vinaphone",
            "Vini",
            "VIP",
            "viptel",
            "Virgin",
            "Virgin Media",
            "Virgin Mobile",
            "Vitelcom Cellular",
            "Viti",
            "Viva",
            "VivaCell-MTS",
            "Vivacom",
            "Vivo",
            "vivohub",
            "Vodacom",
            "Vodacom Lesotho (Pty) Ltd",
            "Vodafone",
            "Vodafone Libertel B.V.",
            "Vodafone Oman",
            "Vodafone/Lycamobile",
            "Vodafone/Truphone",
            "Voice Integrate",
            "Voicetec",
            "Voip Analysis S.A",
            "VOO",
            "VOX",
            "Voxbone",
            "Voxbone SA",
            "Voyacom SPRL",
            "Voyager Internet Limted",
            "Vozelia",
            "VozTelecom",
            "Vtr Banda Ancha (Chile) S.A.",
            "Vtr Comunicaciones Spa.",
            "VTR Móvil",
            "Wafa Telecom",
            "Wan Tok",
            "waoo",
            "Warid",
            "WARSIN HOLDING AB",
            "Watany Ettisalat",
            "Wavecrest",
            "WBS Mobile",
            "Webbing",
            "Webe",
            "Weblink IP Phone",
            "Weblinks Limited",
            "Weelia Enterprise A",
            "West Africa Telecom",
            "WIC",
            "WIFOG AB",
            "Will S.A.",
            "Wind",
            "Winline",
            "WOM",
            "XL",
            "XOX",
            "Xphone",
            "Y",
            "Yemen Mobile",
            "Yettel Hungary",
            "Yim Siam",
            "Yoigo",
            "YouMobile",
            "yousee",
            "Yozma Timeturns sprl -YTT",
            "YTL",
            "Yuboto",
            "Z Mobile",
            "Zain",
            "zain BH",
            "Zain JO",
            "ZAMTEL",
            "Zantel",
            "Zeop",
            "ZEOP Mobile",
            "Zinnia",
            "Ziron",
            "Zong",
        };


    }

