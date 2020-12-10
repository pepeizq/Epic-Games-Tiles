Imports Newtonsoft.Json

Module EpicGamesBBDD

    'https://store-content.ak.epicgames.com/api/en-US/content/store
    'https://store-content.ak.epicgames.com/api/en-US/content/products/ + nameurl
    'https://store-content.ak.epicgames.com/api/content/productmapping

    'pendientes: airborne-kingdom
    '            chivalry-2
    '            chorus
    '            claire-de-lune
    '            demon-turf
    '            far-cry-6
    '            gods-and-monsters
    '            gravewood-high
    '            hitman-3
    '            jett-the-far-shore
    '            kena-bridge-of-spirits
    '            primordials-of-amyrion
    '            prince-of-persia-sands-of-time
    '            rainbow-six-quarantine
    '            recompile
    '            riders-republic
    '            saturnalia
    '            scott-pilgrim-vs-the-world-the-game
    '            sherlock-holmes-chapter-one
    '            super-meat-boy-forever
    '            the-eternal-cylinder
    '            the-outlast-trials
    '            the-settlers
    '            unexplored-2
    '            vampire-the-masquerade-bloodlines-2
    '            vampire-the-masquerade-swansong
    '            wargame-red-dragon
    '            werewolf-the-apocalypse-earthblood

    'retirados
    'New EpicGamesBBDDJuego("Pandemic", "thrasher", "pandemic", True),
    'New EpicGamesBBDDJuego("Paranoia: Happiness is Mandatory", "flamingo", "paranoia", True),
    'New EpicGamesBBDDJuego("The Sinking City", "middlemist", "the-sinking-city", False),

    Public Function Listado()
        Dim lista As New List(Of EpicGamesBBDDJuego) From {
            New EpicGamesBBDDJuego(">observer_", "tumeric", "514900"),
            New EpicGamesBBDDJuego("20XX", "quail", "322110"),
            New EpicGamesBBDDJuego("3 Out of 10 Episode 1 Welcome to Shovelworks", "flounder", Nothing),
            New EpicGamesBBDDJuego("3 Out of 10 Episode 2 Foundation 101", "1317e4e3b3ed40c289dde85b194347d3", Nothing),
            New EpicGamesBBDDJuego("3 out of 10 Episode 3 Pivot Like A Champion", "d86f9cb568014746a15f66025dcc5733", Nothing),
            New EpicGamesBBDDJuego("3 out of 10 Episode 4 Thank You For Being An Asset", "b2f57e24edcb4537bd76dff8b056a03e", Nothing),
            New EpicGamesBBDDJuego("3 out of 10 Episode 5 The Rig Is Up!", "69c5351eacc540fd8850e12e90726e59", Nothing),
            New EpicGamesBBDDJuego("7 Billion Humans", "holly", "792100"),
            New EpicGamesBBDDJuego("A Knights Quest", "cockatoo", Nothing),
            New EpicGamesBBDDJuego("A Short Hike", "d6407c9e6fd54cb492b8c6635480d792", "1055540"),
            New EpicGamesBBDDJuego("A Total War Saga: TROY", "11e598b192324994abce05bad4f81b50", Nothing),
            New EpicGamesBBDDJuego("ABZU", "curry", "384190"),
            New EpicGamesBBDDJuego("AER Memories of Old", "26b63c46de9e4dcc856b3c6b106b6777", "331870"),
            New EpicGamesBBDDJuego("Afterparty", "adenium", "762220"),
            New EpicGamesBBDDJuego("Ageless", "de18a33d6e1f4001b9a3f4a50ef7d760", "1210150"),
            New EpicGamesBBDDJuego("Alan Wake", "heron", "108710"),
            New EpicGamesBBDDJuego("Alan Wake: American Nightmare", "condor", "202750"),
            New EpicGamesBBDDJuego("Alluris", "712a1086c52b413da55f9b38588575d9", "1078510"),
            New EpicGamesBBDDJuego("Amnesia: A Machine for Pigs", "d7db33dfe7634d6b8a188c708f2caa3c", "239200"),
            New EpicGamesBBDDJuego("Amnesia: Rebirth", "f59de18db4dc445f88ffeff24d081234", "999220"),
            New EpicGamesBBDDJuego("Amnesia: The Dark Descent", "ece4c58603d04bcb97454be9a7492fa6", "57300"),
            New EpicGamesBBDDJuego("Among Trees", "dorado", Nothing),
            New EpicGamesBBDDJuego("Ancestors: The Humankind Odyssey", "amaranth", "536270"),
            New EpicGamesBBDDJuego("Anno 1404: History Edition", "f529f5a152014f65821eb900f1c54921", "1281630"),
            New EpicGamesBBDDJuego("Anno 1701: History Edition", "190415920d4a4e3f99043e57e8fabe60", Nothing),
            New EpicGamesBBDDJuego("Anno 1800", "oregano", Nothing),
            New EpicGamesBBDDJuego("Anno 2205", "gulper", "375910"),
            New EpicGamesBBDDJuego("Anodyne 2: Return to Dust", "tanzanite", "877810"),
            New EpicGamesBBDDJuego("Ape Out", "coley", "447150"),
            New EpicGamesBBDDJuego("Aquanox Deep Descent", "c653d74ead8c4940bc121bcccbaf20cf", "254370"),
            New EpicGamesBBDDJuego("Arise: A Simple Story", "rail", "866140"),
            New EpicGamesBBDDJuego("ARK: Survival Evolved", "aafc587fbf654758802c8e41e4fb3255", "346110"),
            New EpicGamesBBDDJuego("art of rally", "01805192c8074820b1257fcfd97f2648", "550320"),
            New EpicGamesBBDDJuego("As Far As The Eye", "09d93e58c5694dc4a709d76887bcd61c", "1119700"),
            New EpicGamesBBDDJuego("Ashen", "wren", "649950"),
            New EpicGamesBBDDJuego("Assassin's Creed: Director's Cut Edition", "0b9d1072cd674b8b91c8e25e9d695ed9", Nothing),
            New EpicGamesBBDDJuego("Assassin's Creed II Deluxe Edition", "d0ae8ca1b5c8421ca6ab892353d3204d", "33230"),
            New EpicGamesBBDDJuego("Assassin's Creed III: Remastered", "anise", Nothing),
            New EpicGamesBBDDJuego("Assassin's Creed Odyssey", "clary", "812140"),
            New EpicGamesBBDDJuego("Assassin's Creed Origins", "camellia", "582160"),
            New EpicGamesBBDDJuego("Assassin's Creed Rogue", "wolffish", "311560"),
            New EpicGamesBBDDJuego("Assassin's Creed Syndicate", "albacore", "368500"),
            New EpicGamesBBDDJuego("Assassin's Creed Unity", "amberjack", "289650"),
            New EpicGamesBBDDJuego("Assassin's Creed Valhalla", "965ccf8b2eba4f9381ef43183c08e205", Nothing),
            New EpicGamesBBDDJuego("Atomicrops", "swan", "757320"),
            New EpicGamesBBDDJuego("Auto Chess", "owl", Nothing),
            New EpicGamesBBDDJuego("Axiom Verge", "puffin", "332200"),
            New EpicGamesBBDDJuego("Aztez", "grunt", "244750"),
            New EpicGamesBBDDJuego("Bad North", "chives", "688420"),
            New EpicGamesBBDDJuego("Barony", "c98c4cd6d83a4524b4b22f13af95a104", "371970"),
            New EpicGamesBBDDJuego("Batman Arkham Asylum", "godwit", "35140"),
            New EpicGamesBBDDJuego("Batman Arkham City", "egret", "200260"),
            New EpicGamesBBDDJuego("Batman Arkham Knight", "cowbird", "208650"),
            New EpicGamesBBDDJuego("Battle Breakers", "wex", Nothing),
            New EpicGamesBBDDJuego("Bee Simulator", "spoonbill", "914750"),
            New EpicGamesBBDDJuego("Before We Leave", "salmon", Nothing),
            New EpicGamesBBDDJuego("Beyond Blue", "3a0cae9455844390ad00505a704d641e", "883360"),
            New EpicGamesBBDDJuego("Beyond Good & Evil", "52f83a6af963426aaee2d603030ef7c9", "15130"),
            New EpicGamesBBDDJuego("Beyond: Two Souls", "lavender", "960990"),
            New EpicGamesBBDDJuego("Blair Witch", "247a0f0f5803429eb3be2c06f3ea77ff", "1092660"),
            New EpicGamesBBDDJuego("Bloodroots", "pochard", "820540"),
            New EpicGamesBBDDJuego("Borderlands 2", "dodo", "49520"),
            New EpicGamesBBDDJuego("Borderlands 3", "catnip", "397540"),
            New EpicGamesBBDDJuego("Borderlands: The Pre-Sequel", "turkey", "261640"),
            New EpicGamesBBDDJuego("Bridge Constructor: The Walking Dead", "998af0ab527c493baefb8049250c9a0e", "1336120"),
            New EpicGamesBBDDJuego("Bugsnax", "bonytail", Nothing),
            New EpicGamesBBDDJuego("Carcassonne: The Official Board Game", "thrush", "598810"),
            New EpicGamesBBDDJuego("Cardpocalypse", "duck", "904400"),
            New EpicGamesBBDDJuego("Carnival Games", "a45b88c3f65d49e68deb166786bf3670", "1249740"),
            New EpicGamesBBDDJuego("Carrion", "9faa3b0871e44b639d49a209f9405aab", "953490"),
            New EpicGamesBBDDJuego("Carto", "cb37006fed8c47db8bcb8a65a59d0f09", "1172450"),
            New EpicGamesBBDDJuego("CastleStorm 2", "dove", Nothing),
            New EpicGamesBBDDJuego("Cave Story+", "1dea8a6ddb544842a58e4b5c8675ff58", "200900"),
            New EpicGamesBBDDJuego("Celeste", "salt", "504230"),
            New EpicGamesBBDDJuego("Child of Light: Ultimate Edition", "3b8f18e6780547d9b2ee25fbfa29c913", Nothing),
            New EpicGamesBBDDJuego("Chronos: Before the Ashes", "8ab5702674e3478583c2c2b50f5b5eff", "967390"),
            New EpicGamesBBDDJuego("City of Brass", "arrowroot", "301840"),
            New EpicGamesBBDDJuego("Close To The Sun", "silene", "968870"),
            New EpicGamesBBDDJuego("Conarium", "canary", "313780"),
            New EpicGamesBBDDJuego("Control Ultimate Edition", "calluna", "870780"),
            New EpicGamesBBDDJuego("Corruption 2029", "betta", Nothing),
            New EpicGamesBBDDJuego("Costume Quest", "violetear", "115100"),
            New EpicGamesBBDDJuego("Costume Quest 2", "82a78a4dd6ef4eaa892707791b705073", "275180"),
            New EpicGamesBBDDJuego("Crashlands", "afdf59e3dc8f40ec8fd887b5d3fcef23", "391730"),
            New EpicGamesBBDDJuego("CRSED: F.O.A.D.", "34eda78a6b24468f9fb70d73793bdaab", "884660"),
            New EpicGamesBBDDJuego("Crysis Remastered", "f1b8986afc9a4256a098cc5a4ebf5871", Nothing),
            New EpicGamesBBDDJuego("Cyberpunk 2077", "ginger", "1091500"),
            New EpicGamesBBDDJuego("Dangerous Driving", "tansy", Nothing),
            New EpicGamesBBDDJuego("Darksiders II Deathinitive Edition", "hoki", "388410"),
            New EpicGamesBBDDJuego("Darksiders III", "springbok", "606280"),
            New EpicGamesBBDDJuego("Darksiders Warmastered Edition", "hake", "462780"),
            New EpicGamesBBDDJuego("Dauntless", "jackal", Nothing),
            New EpicGamesBBDDJuego("Dead Cells", "ca0e1d19d3b640b39d8d20e966067872", "588650"),
            New EpicGamesBBDDJuego("Death Coming", "2333810845fd49a286baf29f9b58f9ae", "705120"),
            New EpicGamesBBDDJuego("Death Stranding", "boga", "1190460"),
            New EpicGamesBBDDJuego("Democracy 4", "5e8da4f19dae455e948e568d8a0272bf", "1410710"),
            New EpicGamesBBDDJuego("Desperados III", "90f2d13d11e74ef29ac1af5c8b0b7730", "610370"),
            New EpicGamesBBDDJuego("Destroy All Humans!", "94232f38800f41b79b49243ada60ff24", "803330"),
            New EpicGamesBBDDJuego("Detroit: Become Human", "columbine", "1222140"),
            New EpicGamesBBDDJuego("Diabotical", "honeycreeper", Nothing),
            New EpicGamesBBDDJuego("Disc Room", "bb026ee643614690b3f65f4f341bae4c", "1229580"),
            New EpicGamesBBDDJuego("Disco Elysium", "7334aba246154b63857435cb9c7eecd5", "632470"),
            New EpicGamesBBDDJuego("Donut County", "kestrel", "702670"),
            New EpicGamesBBDDJuego("DRAGON QUEST XI S: Echoes of an Elusive Age – Definitive Edition", "938603e109ab4b0b9304b2a8aac78280", "1295510"),
            New EpicGamesBBDDJuego("Drawful 2", "daisy", "442070"),
            New EpicGamesBBDDJuego("Dread Nautical", "opah", "1426900"),
            New EpicGamesBBDDJuego("Dungeons 3", "351fe5b32e22412d8fa41f4c7395fed1", "493900"),
            New EpicGamesBBDDJuego("Elite Dangerous", "9c203b6ed35846e8a4a9ff1e314f6593", "359320"),
            New EpicGamesBBDDJuego("Empires of the Undergrowth", "c9fa09b072b54443b79d821afd76e767", "463530"),
            New EpicGamesBBDDJuego("Enter the Gungeon", "garlic", "311690"),
            New EpicGamesBBDDJuego("Evan's Remains", "177b5daea3844316aea9f86d7fb7b8da", "1110050"),
            New EpicGamesBBDDJuego("Everything", "pelican", "582270"),
            New EpicGamesBBDDJuego("Faeria", "vulture", "397060"),
            New EpicGamesBBDDJuego("Falcon Age", "parrot", "1075080"),
            New EpicGamesBBDDJuego("Far Cry", "c9d31937de5b45efb95b515b35a4960b", "13520"),
            New EpicGamesBBDDJuego("Far Cry 2: Fortune's Edition", "3b78108a811d497db768899400edd842", "19900"),
            New EpicGamesBBDDJuego("Far Cry 3", "hellebore", "220240"),
            New EpicGamesBBDDJuego("Far Cry 3 Blood Dragon", "hapuka", "233270"),
            New EpicGamesBBDDJuego("Far Cry 4", "tautog", "298110"),
            New EpicGamesBBDDJuego("Far Cry 5", "coriander", "552520"),
            New EpicGamesBBDDJuego("Far Cry New Dawn", "cumin", "939960"),
            New EpicGamesBBDDJuego("Far Cry Primal", "larkspur", "371660"),
            New EpicGamesBBDDJuego("Farming Simulator 19", "stellula", "787860"),
            New EpicGamesBBDDJuego("Fez", "bluebird", "224760"),
            New EpicGamesBBDDJuego("Figment", "ed5e8d42b2ac461eb6f9176d163b9515", "493540"),
            New EpicGamesBBDDJuego("Flower", "yarrow", "966330"),
            New EpicGamesBBDDJuego("Football Manager 2020", "bf35243e8c3542e082bc7042e0592183", "1100600"),
            New EpicGamesBBDDJuego("Football Manager 2021", "6f5862ba65244cfe86490f253d64feb1", "1263850"),
            New EpicGamesBBDDJuego("For Honor", "sundrop", "304390"),
            New EpicGamesBBDDJuego("For The King", "discus", "527230"),
            New EpicGamesBBDDJuego("Foregone", "dab", "1000760"),
            New EpicGamesBBDDJuego("Fortnite", "fortnite", Nothing),
            New EpicGamesBBDDJuego("Freedom Fighters", "0d771750aa9042898ce100dbfb5efb1a", "1347780"),
            New EpicGamesBBDDJuego("FTL: Faster Than Light", "blowfish", "212680"),
            New EpicGamesBBDDJuego("Fuser", "2939f4752d4b4ace95a8e1b16e79d3f5", "1331440"),
            New EpicGamesBBDDJuego("Genesis Alpha One Deluxe Edition", "puma", "712190"),
            New EpicGamesBBDDJuego("Ghostbusters: The Video Game Remastered", "mint", "1449280"),
            New EpicGamesBBDDJuego("Ghostrunner", "ea8df71f923649a193ab1c1fded7e1b3", "1139900"),
            New EpicGamesBBDDJuego("GNOG", "penguin", "290510"),
            New EpicGamesBBDDJuego("Godfall", "carp", Nothing),
            New EpicGamesBBDDJuego("God's Trigger", "9bc4423d873845739cc99ab69b6bfbe9", "488730"),
            New EpicGamesBBDDJuego("Going Under", "5f4a39950a1d49c3a3ebad181a6c05fa", "1154810"),
            New EpicGamesBBDDJuego("Gone Home", "flier", "232430"),
            New EpicGamesBBDDJuego("GoNNER", "emperor", "437570"),
            New EpicGamesBBDDJuego("Gorogoa", "meerkat", "557600"),
            New EpicGamesBBDDJuego("Grand Theft Auto V", "9d2d0eb64d5c44529cece33fe2a46482", "271590"),
            New EpicGamesBBDDJuego("Griftlands", "phlox", "601840"),
            New EpicGamesBBDDJuego("Hades", "min", "1145360"),
            New EpicGamesBBDDJuego("Hammerting", "60dc80f49cf34a479df2c823df30e9ac", "760650"),
            New EpicGamesBBDDJuego("Heavy Rain", "aster", "960910"),
            New EpicGamesBBDDJuego("Hello Neighbor", "ursus", "521890"),
            New EpicGamesBBDDJuego("Hello Neighbor Hide & Seek", "morpho", "960420"),
            New EpicGamesBBDDJuego("Hellpoint", "210733411fa44d5f8454a1bb435db3a9", "628670"),
            New EpicGamesBBDDJuego("Heroes & Generals WWII", "8836f84a700140bb86103556cd7db0d4", "227940"),
            New EpicGamesBBDDJuego("HITMAN", "barbet", "236870"),
            New EpicGamesBBDDJuego("Hob", "lyrebird", "404680"),
            New EpicGamesBBDDJuego("Horace", "palila", "629090"),
            New EpicGamesBBDDJuego("Horizon Zero Dawn Complete Edition", "grunion", "1151640"),
            New EpicGamesBBDDJuego("Hue", "herring", "383270"),
            New EpicGamesBBDDJuego("Human Resource Machine", "basil", "375820"),
            New EpicGamesBBDDJuego("Huntdown", "337ffb9c2d624545be086e6ead40dbbe", "598550"),
            New EpicGamesBBDDJuego("Hyper Light Drifter", "parakeet", "257850"),
            New EpicGamesBBDDJuego("I Am Dead", "32d8f5e15ceb425e8d7d980bfa29db39", "951750"),
            New EpicGamesBBDDJuego("Industries of Titan", "protea", "427940"),
            New EpicGamesBBDDJuego("Immortals Fenyx Rising", "pheasant", Nothing),
            New EpicGamesBBDDJuego("InnerSpace", "almond", "347000"),
            New EpicGamesBBDDJuego("INSIDE", "marigold", "304430"),
            New EpicGamesBBDDJuego("Into The Breach", "blobfish", "590380"),
            New EpicGamesBBDDJuego("Iron Harvest", "2877ce04ee7c4c1c8ce4c7245875ed6c", "826630"),
            New EpicGamesBBDDJuego("John Wick Hex", "vanilla", "1405790"),
            New EpicGamesBBDDJuego("Jotun: Valhalla Edition", "grouse", "323580"),
            New EpicGamesBBDDJuego("Journey", "lemur", "638230"),
            New EpicGamesBBDDJuego("Journey to the Savage Planet", "oleander", Nothing),
            New EpicGamesBBDDJuego("Just Cause 4 Reloaded", "kakopo", "517630"),
            New EpicGamesBBDDJuego("Kill it With Fire", "123be6a3d02647df8f09a7da3eab7568", "1179210"),
            New EpicGamesBBDDJuego("Killing Floor 2", "finch", "232090"),
            New EpicGamesBBDDJuego("Kine", "rose", "824570"),
            New EpicGamesBBDDJuego("Kingdom Come: Deliverance", "eel", "379430"),
            New EpicGamesBBDDJuego("Kingdom New Lands", "cacao", "496300"),
            New EpicGamesBBDDJuego("Kingdoms of Amalur Re-Reckoning", "b8aa8afb7da84da3a978425ec4b8e5cd", "1041720"),
            New EpicGamesBBDDJuego("Last Day of June", "pumpkin", "635320"),
            New EpicGamesBBDDJuego("Layers of Fear", "cilantro", "391720"),
            New EpicGamesBBDDJuego("Layers of Fear 2", "473e24df09f843a1acc4aa16b01dae83", "1029890"),
            New EpicGamesBBDDJuego("LEGO Batman: The Videogame", "goldeneye", "21000"),
            New EpicGamesBBDDJuego("LEGO Batman 2: DC Super Heroes", "grackle", "213330"),
            New EpicGamesBBDDJuego("LEGO Batman 3: Beyond Gotham", "gull", "313690"),
            New EpicGamesBBDDJuego("Levelhead", "196ba0d44d914ef69499877e53fa500d", "792710"),
            New EpicGamesBBDDJuego("Lifeless Planet Premier Edition", "860a4feefe2a4f48905ae86c61d5db64", "261530"),
            New EpicGamesBBDDJuego("Limbo", "hazelnut", "48000"),
            New EpicGamesBBDDJuego("Little Inferno", "clover", "221260"),
            New EpicGamesBBDDJuego("Mafia: Definitive Edition", "kunzite", "1030840"),
            New EpicGamesBBDDJuego("Mafia II: Definitive Edition", "c070615314394e1ca8d4b66e5edf949b", "1030830"),
            New EpicGamesBBDDJuego("Mafia III: Definitive Edition", "7dd3049c1e4f47d3976b4ef55d07bbcc", "360430"),
            New EpicGamesBBDDJuego("Magic The Gathering Arena", "stargazer", Nothing),
            New EpicGamesBBDDJuego("Maneater", "turtle", "629820"),
            New EpicGamesBBDDJuego("Manifold Garden", "lorikeet", "473950"),
            New EpicGamesBBDDJuego("Mechwarrior 5", "hoopoe", Nothing),
            New EpicGamesBBDDJuego("Metro 2033 Redux", "petunia", "286690"),
            New EpicGamesBBDDJuego("Metro Exodus", "snapdragon", "412020"),
            New EpicGamesBBDDJuego("Metro Last Light Redux", "speedwell", "287390"),
            New EpicGamesBBDDJuego("Might & Magic Chess Royale", "b141e42965ff431aa0e23bf3d5635942", Nothing),
            New EpicGamesBBDDJuego("Might & Magic Heroes VII: Ultimate Edition", "f324cf34cd1a4a94901e003d14da37b1", "321960"),
            New EpicGamesBBDDJuego("Milky Way Prince – The Vampire Star", "97d90ab4704344e9b6f255994fee639c", "1302050"),
            New EpicGamesBBDDJuego("Minit", "petrel", "609490"),
            New EpicGamesBBDDJuego("Missile Command: Recharged", "fe014df1aa2c465aae88138c4307b11a", "1292010"),
            New EpicGamesBBDDJuego("Monopoly PLUS", "hamlet", "562810"),
            New EpicGamesBBDDJuego("Moonlighter", "eagle", "606150"),
            New EpicGamesBBDDJuego("Mortal Shell", "0055e45ce7654c55aade646467349e83", "1110910"),
            New EpicGamesBBDDJuego("Mount & Blade II: Bannerlord", "chickadee", "261550"),
            New EpicGamesBBDDJuego("MudRunner", "bulbul", "675010"),
            New EpicGamesBBDDJuego("Mutant Year Zero: Road to Eden", "falcon", "760060"),
            New EpicGamesBBDDJuego("Mutazione", "1fe19232c0f7476a8e99fd8752e800c2", "1080750"),
            New EpicGamesBBDDJuego("My Time At Portia", "cobra", "666140"),
            New EpicGamesBBDDJuego("Neighbours back From Hell", "ada6f617bc3f4042a7f2f7533f3573e8", "1283190"),
            New EpicGamesBBDDJuego("Neon Abyss", "a26f991a5e6c4e9c9572fc200cbea47f", "788100"),
            New EpicGamesBBDDJuego("Neverwinter", "87be9bd6707748888bce1f79b025c5dd", "109600"),
            New EpicGamesBBDDJuego("Next Up Hero", "sumac", "667810"),
            New EpicGamesBBDDJuego("New Super Lucky's Tale", "f7af594eebf542fc91dfc911f5f1e1d2", "1038300"),
            New EpicGamesBBDDJuego("No Straight Roads", "raven", Nothing),
            New EpicGamesBBDDJuego("Nuclear Throne", "turaco", "242680"),
            New EpicGamesBBDDJuego("Observation", "allium", "906100"),
            New EpicGamesBBDDJuego("Observer: System Redux", "96bd88a871c24768a7cf1b9b9fbc5aa5", "1386900"),
            New EpicGamesBBDDJuego("Offworld Trading Company", "snapper", "271240"),
            New EpicGamesBBDDJuego("Old World", "nightjar", Nothing),
            New EpicGamesBBDDJuego("Omen Of Sorrow", "daffodil", Nothing),
            New EpicGamesBBDDJuego("Ooblets", "ostrich", Nothing),
            New EpicGamesBBDDJuego("Operencia: The Stolen Sun", "lily", "985950"),
            New EpicGamesBBDDJuego("Orwell's Animal Farm", "2d2246bc1e8148a1a9afc34983891db4", "1398100"),
            New EpicGamesBBDDJuego("Outer Wilds", "starfish", "753640"),
            New EpicGamesBBDDJuego("Outward", "viola", "794260"),
            New EpicGamesBBDDJuego("Overcooked", "sage", "448510"),
            New EpicGamesBBDDJuego("Overpass", "sandpiper", "970840"),
            New EpicGamesBBDDJuego("Oxenfree", "hibiscus", "388880"),
            New EpicGamesBBDDJuego("Oxygen Not Included", "lotus", "457140"),
            New EpicGamesBBDDJuego("Paladins", "antbird", "444090"),
            New EpicGamesBBDDJuego("Paper Beast", "06efba7b35c6459cba1919c524c0d7fa", "1232570"),
            New EpicGamesBBDDJuego("Path of Exile", "9a05967bb86f48278f8626be42548985", "238960"),
            New EpicGamesBBDDJuego("Pathway", "8fceb562623c430db9bb6abf0549c43e", "546430"),
            New EpicGamesBBDDJuego("Phantom Brigade", "chili", "553540"),
            New EpicGamesBBDDJuego("Phoenix Point: Year One Edition", "iris", "839770"),
            New EpicGamesBBDDJuego("Pikuniku", "48619f5656da446abccb727b78cda644", "572890"),
            New EpicGamesBBDDJuego("Pillars of Eternity - Definitive Edition", "bcc75c246fe04e45b0c1f1c3fd52503a", "291650"),
            New EpicGamesBBDDJuego("Poly Bridge 2", "03e51fc525b24b2ea873ac13c16b9ed7", "1062160"),
            New EpicGamesBBDDJuego("Port Royale 4", "dd4b77658e5546d882a9315b66d0a192", "1024650"),
            New EpicGamesBBDDJuego("Predator: Hunting Grounds", "boxfish", Nothing),
            New EpicGamesBBDDJuego("Primordials of Amyrion", "c279ad508db0453fa99f1d1ebb698c80", "1316870"),
            New EpicGamesBBDDJuego("Production Line: Car factory simulation", "c041feb3a2e74fb9bc520ec93099a081", "591370"),
            New EpicGamesBBDDJuego("Pumpkin Jack", "9fef3b816031450da8ba85b23820cfbb", "1186640"),
            New EpicGamesBBDDJuego("Q.U.B.E. 2", "auk", "359100"),
            New EpicGamesBBDDJuego("Railway Empire", "8cf7c6b964514532ad8284a376a517bf", "503940"),
            New EpicGamesBBDDJuego("Raji: An Ancient Epic", "e6dca9926c204374ab209d85a2c1203e", "730390"),
            New EpicGamesBBDDJuego("Rayman Legends", "anchovy", "242550"),
            New EpicGamesBBDDJuego("ReadySet Heroes", "peacock", Nothing),
            New EpicGamesBBDDJuego("Rebel Galaxy", "weaver", "290300"),
            New EpicGamesBBDDJuego("Rebel Galaxy Outlaw", "rgo", "910830"),
            New EpicGamesBBDDJuego("Red Dead Redemption 2", "heather", "1174180"),
            New EpicGamesBBDDJuego("Relicta", "b4670484aae24db492f0b468a98fe361", "941570"),
            New EpicGamesBBDDJuego("Remnant: From the Ashes", "b4a0d2d15acb4db894a599b810297543", "617290"),
            New EpicGamesBBDDJuego("RiME", "hydrangea", "493200"),
            New EpicGamesBBDDJuego("RimWorld", "12915f06bb3442eeb414813e74af7df3", "294100"),
            New EpicGamesBBDDJuego("Rising Storm 2: Vietnam", "tern", "418460"),
            New EpicGamesBBDDJuego("Rocket League", "sugar", Nothing),
            New EpicGamesBBDDJuego("Rogue Company", "pewee", Nothing),
            New EpicGamesBBDDJuego("Rogue Legacy 2", "bd35425c9548494082d002f36601ff45", "1253920"),
            New EpicGamesBBDDJuego("RollerCoaster Tycoon 3: Complete Edition", "281a47e363284108b82bf05c1a612145", "1368820"),
            New EpicGamesBBDDJuego("RollerCoaster Tycoon Adventures", "canna", Nothing),
            New EpicGamesBBDDJuego("RUINER", "laridae", "464060"),
            New EpicGamesBBDDJuego("RUNE II: Decapitation Edition", "cosmos", "821290"),
            New EpicGamesBBDDJuego("Saint's Row The Third Remastered", "loon", Nothing),
            New EpicGamesBBDDJuego("Samurai Jack: Battle Through Time", "4fcc58f22bbb42a4a1ee0cc887c0836e", "1150590"),
            New EpicGamesBBDDJuego("SAMURAI SHODOWN", "1c78abcd467643f9ad58cc3a7d161983", Nothing),
            New EpicGamesBBDDJuego("SAMURAI SHODOWN NEOGEO COLLECTION", "75553c71fa1744a4be89f71d5b862eae", "999660"),
            New EpicGamesBBDDJuego("Satisfactory", "crab", "526870"),
            New EpicGamesBBDDJuego("Scourgebringer", "bf363d9625a5406f904d925f3e613327", "1037020"),
            New EpicGamesBBDDJuego("Shadow Complex", "vpr", Nothing),
            New EpicGamesBBDDJuego("Shadow Tactics: Blades of the Shogun", "fangtooth", "418240"),
            New EpicGamesBBDDJuego("Shadowrun Dragonfall - Director’s Cut", "5b41454974be4d5883056ba298e53675", "300550"),
            New EpicGamesBBDDJuego("Shadowrun: Hong Kong - Extended Edition", "41470cb5755440b8b55ec3f94351133a", "346940"),
            New EpicGamesBBDDJuego("Shadowrun Returns", "dc29cb42f32e4a17af1d68c715fa459c", "234650"),
            New EpicGamesBBDDJuego("Shakedown Hawaii", "plumeria", "598730"),
            New EpicGamesBBDDJuego("Shenmue III", "pepper", "878670"),
            New EpicGamesBBDDJuego("Sherlock Holmes: Crimes and Punishments", "0afb9d54dd3743a582b48b506466d3f8", "241260"),
            New EpicGamesBBDDJuego("Sherlock Holmes: The Devil's Daughter", "cinnamon", "350640"),
            New EpicGamesBBDDJuego("Sid Meier’s Civilization VI", "kinglet", "289070"),
            New EpicGamesBBDDJuego("Slime Rancher", "corydalis", "433340"),
            New EpicGamesBBDDJuego("Sludge Life", "morganite", Nothing),
            New EpicGamesBBDDJuego("SMITE", "greenbul", "386360"),
            New EpicGamesBBDDJuego("Snowrunner", "mayflower", Nothing),
            New EpicGamesBBDDJuego("SOMA", "emu", "282140"),
            New EpicGamesBBDDJuego("South Park: The Fractured But Whole", "alewife", "488790"),
            New EpicGamesBBDDJuego("South Park: The Stick of Truth", "alligator", "213670"),
            New EpicGamesBBDDJuego("Spellbreak", "newt", "1399780"),
            New EpicGamesBBDDJuego("Spiritfarer", "740bb3cae62142d08e9fdf8262da352f", "972660"),
            New EpicGamesBBDDJuego("SpongeBob SquarePants: Battle for Bikini Bottom - Rehydrated", "f2304175954d40d2b583542251dda296", "969990"),
            New EpicGamesBBDDJuego("Star Trek Online", "0fb6e06aacd14e88b1aaea8f54dd8525", "9900"),
            New EpicGamesBBDDJuego("Star Wars Jedi Fallen Order", "shoebill", "1172380"),
            New EpicGamesBBDDJuego("Star Wars Squadrons", "bobcat", "1222730"),
            New EpicGamesBBDDJuego("Startup Panic", "7003e758ed3a4790a36ad41c2d08f8b6", "1045610"),
            New EpicGamesBBDDJuego("State of Decay 2: Juggernaut Edition", "snoek", "495420"),
            New EpicGamesBBDDJuego("Steep", "barracuda", "460920"),
            New EpicGamesBBDDJuego("Stick It To The Man!", "goldfish", "251830"),
            New EpicGamesBBDDJuego("Stories Untold", "parsley", "558420"),
            New EpicGamesBBDDJuego("Stranger Things 3: The Game", "0a697c1235fb4706a635cfa33f0306ec", "1097800"),
            New EpicGamesBBDDJuego("Subnautica", "jaguar", "264710"),
            New EpicGamesBBDDJuego("Subnautica: Below Zero", "foxglove", "848450"),
            New EpicGamesBBDDJuego("Sundered: Eldritch Edition", "moa", "535480"),
            New EpicGamesBBDDJuego("Super Meat Boy", "buffalo", "40800"),
            New EpicGamesBBDDJuego("Superbrothers: Sword & Sworcery EP", "f6d328ca5be24fd585478d1477e1ea4d", "204060"),
            New EpicGamesBBDDJuego("SUPERHOT: Mind Control Delete", "7c9f2b7aa5a549e381b4e6aeff3779a1", "690040"),
            New EpicGamesBBDDJuego("Superliminal", "wigeon", "1049410"),
            New EpicGamesBBDDJuego("SuperMash", "nutmeg", "872720"),
            New EpicGamesBBDDJuego("Surgeon Simulator 2", "tanager", Nothing),
            New EpicGamesBBDDJuego("Surviving Mars", "ovenbird", "464920"),
            New EpicGamesBBDDJuego("Surviving the Aftermath", "muscovy", "684450"),
            New EpicGamesBBDDJuego("Tacoma", "flagfin", "343860"),
            New EpicGamesBBDDJuego("Tetris Effect", "kiwi", Nothing),
            New EpicGamesBBDDJuego("The Alto Collection", "hornbill", Nothing),
            New EpicGamesBBDDJuego("The Bridge", "sunbird", "204240"),
            New EpicGamesBBDDJuego("The Crew 2", "hermit", "646910"),
            New EpicGamesBBDDJuego("The Cycle", "azalea", "868270"),
            New EpicGamesBBDDJuego("The Dungeon Of Naheulbeuk: The Amulet Of Chaos", "02fac38ee2614c8ba276b1ea7c1acd7c", "970830"),
            New EpicGamesBBDDJuego("The End is Nigh", "statice", "583470"),
            New EpicGamesBBDDJuego("The Escapists", "peony", "298630"),
            New EpicGamesBBDDJuego("The Escapists 2", "fowl", "641990"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack", "feverfew", "331670"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 2", "lilac", "397460"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 3", "orchid", "434170"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 4", "snowdrop", "610180"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 5", "geranium", "774461"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 6", "astrapia", "1005300"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 7", "7fb6ce95c6d04a44a55fef16ea0db4c9", "1211630"),
            New EpicGamesBBDDJuego("The Last Campfire", "c713e12721894fcdbc59ad9ff3fd8a69", "990630"),
            New EpicGamesBBDDJuego("The Messenger", "jay", "764790"),
            New EpicGamesBBDDJuego("The Outer Worlds", "rosemallow", "578650"),
            New EpicGamesBBDDJuego("The Pathless", "geum", Nothing),
            New EpicGamesBBDDJuego("The Red Lantern", "guillemot", Nothing),
            New EpicGamesBBDDJuego("The Sojourn", "shallots", "794960"),
            New EpicGamesBBDDJuego("The Solitaire Conspiracy", "162623ee6c524e41919d1efa24ce58ce", "1424980"),
            New EpicGamesBBDDJuego("The Stanley Parable", "freesia", "221910"),
            New EpicGamesBBDDJuego("The Talos Principle", "bustard", "257510"),
            New EpicGamesBBDDJuego("The Telltale Batman Shadows Edition", "batfish", Nothing),
            New EpicGamesBBDDJuego("The Textorcist: The Story of Ray Bibbia", "50d8518151d0498b83ff5d18a7bdb68b", "940680"),
            New EpicGamesBBDDJuego("The Unfinished Swan", "f58bb43636064a0295781853ef8405fb", "1206430"),
            New EpicGamesBBDDJuego("The Walking Dead: A New Frontier", "begonia", "536220"),
            New EpicGamesBBDDJuego("The Walking Dead: Final Season", "ocelot", "866800"),
            New EpicGamesBBDDJuego("The Walking Dead: Michonne", "fennel", "429570"),
            New EpicGamesBBDDJuego("The Walking Dead: Season One", "bloodroot", "207610"),
            New EpicGamesBBDDJuego("The Walking Dead: Season Two", "buttercup", "261030"),
            New EpicGamesBBDDJuego("The Walking Dead: The Telltale Definitive Series", "cuckoo", "1449690"),
            New EpicGamesBBDDJuego("The Witcher 3: Wild Hunt - Game of the Year Edition", "725a22e15ed74735bb0d6a19f3cc82d0", "292030"),
            New EpicGamesBBDDJuego("The Witness", "magnolia", "210970"),
            New EpicGamesBBDDJuego("The Wolf Among Us", "cobbler", "250320"),
            New EpicGamesBBDDJuego("The World Next Door", "39a0313492c84cf79b119efb09df90e5", "755470"),
            New EpicGamesBBDDJuego("This War of Mine", "cardinal", "282070"),
            New EpicGamesBBDDJuego("Thimbleweed Park", "tulip", "569860"),
            New EpicGamesBBDDJuego("Ticket to Ride", "towhee", "108200"),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Breakpoint", "saffron", Nothing),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Future Soldier Ultimate Edition", "e7471b6a7335415db9819ef7e7e77c29", Nothing),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Wildlands", "hyacinth", "460930"),
            New EpicGamesBBDDJuego("Tom Clancy's Rainbow Six Siege", "carnation", "359550"),
            New EpicGamesBBDDJuego("Tom Clancy's The Division", "e4eb21a09dc049e982359b1e133ccebf", "365590"),
            New EpicGamesBBDDJuego("Tom Clancy's The Division 2", "impala", Nothing),
            New EpicGamesBBDDJuego("Tony Hawk's Pro Skater 1 + 2", "guppy", Nothing),
            New EpicGamesBBDDJuego("Torchlight", "terragon", "41500"),
            New EpicGamesBBDDJuego("Torchlight II", "8e425d507bd6473dbb927f0fea8ef4f6", "200710"),
            New EpicGamesBBDDJuego("Tormentor X Punisher", "goby", "500670"),
            New EpicGamesBBDDJuego("Totally Accurate Battle Simulator", "driftfish", "508440"),
            New EpicGamesBBDDJuego("Totally Reliable Delivery Service", "hoatzin", "1011670"),
            New EpicGamesBBDDJuego("TowerFall Ascension", "bichir", "251470"),
            New EpicGamesBBDDJuego("Trackmania", "pigeon", Nothing),
            New EpicGamesBBDDJuego("Trackmania Turbo", "a18915c48f584670bd236ce3031d63d9", "375900"),
            New EpicGamesBBDDJuego("Transistor", "dill", "237930"),
            New EpicGamesBBDDJuego("Trials Rising", "argyle", "641080"),
            New EpicGamesBBDDJuego("Trover Saves the Universe", "sweetpea", "1051200"),
            New EpicGamesBBDDJuego("Twin Mirror", "58d0d56cb2f5475cbd89fed5beb44215", Nothing),
            New EpicGamesBBDDJuego("Tyranny - Gold Edition", "36b0e40890f147fbb1e3965f87369156", "362960"),
            New EpicGamesBBDDJuego("UNO", "hussar", "470220"),
            New EpicGamesBBDDJuego("Unreal Tournament", "ut", Nothing),
            New EpicGamesBBDDJuego("Untitled Goose Game", "flour", "837470"),
            New EpicGamesBBDDJuego("Valiant Hearts: The Great War", "f6496e154baa437cb4d9cae38a7e3cc5", "260230"),
            New EpicGamesBBDDJuego("Vampyr", "nautilus", "427290"),
            New EpicGamesBBDDJuego("Warhammer 40,000: Gladius - Relics of War", "da5b18cb1e7a452196c3142f2c1d7dd3", "489630"),
            New EpicGamesBBDDJuego("Watch Dogs", "jasper", "243470"),
            New EpicGamesBBDDJuego("Watch Dogs 2", "angelonia", "447040"),
            New EpicGamesBBDDJuego("Watch Dogs Legion", "hawk", Nothing),
            New EpicGamesBBDDJuego("Wattam", "lupine", "702680"),
            New EpicGamesBBDDJuego("What Remains of Edith Finch", "badger", "501300"),
            New EpicGamesBBDDJuego("What the Golf?", "stork", "785790"),
            New EpicGamesBBDDJuego("Wheels of Aurelia", "escolar", "508740"),
            New EpicGamesBBDDJuego("Where The Water Tastes Like Wine", "e8964b869b6849bea41eefec766cd665", "447120"),
            New EpicGamesBBDDJuego("Whispers of a Machine", "f98f2879f12f42bbbe767db90907d1ab", "631570"),
            New EpicGamesBBDDJuego("Wilmot's Warehouse", "9b40e3ffb4074f22a856a521be5ce858", "839870"),
            New EpicGamesBBDDJuego("Windbound", "a95bf4df6627431ca5baff8173c59635", "1162130"),
            New EpicGamesBBDDJuego("Wizards: Wand of Epicosity", "a19c886dab804ef0a0e095874c7e0d00", "772750"),
            New EpicGamesBBDDJuego("World of Goo", "anemone", "22000"),
            New EpicGamesBBDDJuego("World War Z", "wombat", Nothing),
            New EpicGamesBBDDJuego("WRC 8 FIA World Rally Championship", "woodpecker", "1004750"),
            New EpicGamesBBDDJuego("WRC 9 FIA World Rally Championship", "kagu", Nothing),
            New EpicGamesBBDDJuego("Yaga", "robin", "888530"),
            New EpicGamesBBDDJuego("Yooka-Laylee and the Impossible Lair", "duckbill", "846870"),
            New EpicGamesBBDDJuego("Zombi", "91b23d48ead64764b90a217a11baf209", "339230"),
            New EpicGamesBBDDJuego("Zombie Army 4: Dead War", "sparrow", Nothing)
        }

        Return lista
    End Function

End Module

Public Class EpicGamesBBDDJuego

    Public Titulo As String
    Public IDEpic As String
    Public IDSteam As String

    Public Sub New(ByVal titulo As String, ByVal idEpic As String, ByVal idSteam As String)
        Me.Titulo = titulo
        Me.IDEpic = idEpic
        Me.IDSteam = idSteam
    End Sub

End Class

'-------------------------------------------------------------------

Public Class EpicGamesJuego

    <JsonProperty("productName")>
    Public Titulo As String

    <JsonProperty("pages")>
    Public Paginas As List(Of EpicGamesJuegoPagina)

    <JsonProperty("reviewOptOut")>
    Public ReviewNo As Boolean

End Class

Public Class EpicGamesJuegoPagina

    <JsonProperty("item")>
    Public Clave As EpicGamesJuegoClave

    <JsonProperty("data")>
    Public Datos As EpicGamesJuegoDatos

    <JsonProperty("_images_")>
    Public Capturas As List(Of String)

    <JsonProperty("_urlPattern")>
    Public Patron As String

End Class

Public Class EpicGamesJuegoClave

    <JsonProperty("appName")>
    Public App As String

    <JsonProperty("namespace")>
    Public Space As String

End Class

Public Class EpicGamesJuegoDatos

    <JsonProperty("hero")>
    Public Imagenes As EpicGamesJuegoImagenes

End Class

Public Class EpicGamesJuegoImagenes

    <JsonProperty("logoImage")>
    Public Logo As EpicGamesJuegoImagenesFuente

    <JsonProperty("portraitBackgroundImageUrl")>
    Public Vertical As String

    <JsonProperty("backgroundImageUrl")>
    Public Horizontal As String

End Class

Public Class EpicGamesJuegoImagenesFuente

    <JsonProperty("src")>
    Public Url As String

End Class