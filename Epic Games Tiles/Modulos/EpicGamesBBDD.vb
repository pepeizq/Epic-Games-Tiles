Imports Newtonsoft.Json

Module EpicGamesBBDD

    'https://store-content.ak.epicgames.com/api/en-US/content/store
    'https://store-content.ak.epicgames.com/api/en-US/content/products/ + nameurl
    'https://store-content.ak.epicgames.com/api/content/productmapping

    'pendientes: 
    'adios-b378b4
    'aerial-knights-never-yield
    'alex-kidd-in-miracle-world-dx
    'arcadegeddon
    'backbone
    'beasts-of-maravilla-island
    'biomutant
    'black-skylands
    'chicory-a-colorful-tale
    'chicken-police-paint-it-red
    'claire-de-lune
    'crash-drive-3
    'cris-tales
    'crystal-crisis
    'dark-future-blood-red-states
    'darksiders-genesis
    'days-gone
    'deaths-door
    'deepest-chamber-f7085f
    'deep-sky-derelicts
    'demons-tilt
    'doctor-who-the-lonely-assassins
    'doki-doki-literature-club-plus
    'dream-engines-nomad-cities
    'edge-of-eternity
    'going-medieval
    'graven
    'grindstone
    'hood-outlaws-And-legends
    'hundred-days-winemaking-simulator
    'just-die-already
    'knockout-city
    'lego-builders-journey
    'little-big-workshop
    'lovecrafts-untold-stories
    'lunas-fishing-garden
    'mars-horizon
    'mayhem-in-single-valley
    'necroland-undead-corps
    'necromunda-hired-gun
    'northgard
    'open-country
    'out-of-line-209cbb
    'pascals-wager
    'pathfinder-kingmaker
    'r-type-final-2
    'real-farm-gold-edition
    'realpolitiks-2
    'sakuna-of-rice-and-ruin
    'siege-survival-gloria-victis
    'skate-city
    'slipways
    'sockventure
    'song-of-farca-1eb3f2
    'space-punks--founders-splendor-pack
    'spellforce-3-soul-harvest
    'stonefly
    'suchart-genius-artist-simulator
    'supraland
    'suzerain
    'swords-of-legends-online
    'tannenberg
    'tennis-manager-2021
    'the-architect-paris
    'the-banner-saga-epic-trilogy
    'the-chameleon
    'the-count-lucanor
    'the-hand-of-merlin
    'the-longest-road-on-earth
    'the-uncertain-light-at-the-end
    'timelie
    'tower-of-guns
    'trials-of-fire
    'truck-driver
    'unexplored-2
    'viscerafest
    'wanna-survive
    'warhammer-40000-battlesector
    'we-are-football
    'worms-rumble
    'ys-ix-monstrum-nox
    'yuppie-psycho

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
            New EpicGamesBBDDJuego("3 out of 10: Season Two", "9a1aae61129247fb971ce96ab6a959da", Nothing),
            New EpicGamesBBDDJuego("7 Billion Humans", "holly", "792100"),
            New EpicGamesBBDDJuego("A Good Snowman is Hard to Build", "8760ffb4aaed4482a97553a7faca8277", "316610"),
            New EpicGamesBBDDJuego("A Knights Quest", "cockatoo", Nothing),
            New EpicGamesBBDDJuego("A Monster's Expedition", "9050026cc16c44b8b4e69f160c4bb5d5", "1052990"),
            New EpicGamesBBDDJuego("A Short Hike", "d6407c9e6fd54cb492b8c6635480d792", "1055540"),
            New EpicGamesBBDDJuego("A Total War Saga: TROY", "11e598b192324994abce05bad4f81b50", Nothing),
            New EpicGamesBBDDJuego("Absolute Drift", "19927295d6e3467887d4e830d8c85963", "320140"),
            New EpicGamesBBDDJuego("ABZU", "curry", "384190"),
            New EpicGamesBBDDJuego("AER Memories of Old", "26b63c46de9e4dcc856b3c6b106b6777", "331870"),
            New EpicGamesBBDDJuego("Afterparty", "adenium", "762220"),
            New EpicGamesBBDDJuego("Ageless", "de18a33d6e1f4001b9a3f4a50ef7d760", "1210150"),
            New EpicGamesBBDDJuego("Aground", "bde0d8274dc64fe98e2e0867401b1de4", "876650"),
            New EpicGamesBBDDJuego("Airborne Kingdom", "macaw", Nothing),
            New EpicGamesBBDDJuego("Alan Wake", "heron", "108710"),
            New EpicGamesBBDDJuego("Alan Wake: American Nightmare", "condor", "202750"),
            New EpicGamesBBDDJuego("Alien: Isolation", "8935bb3e1420443a9789fe01758039a5", "214490"),
            New EpicGamesBBDDJuego("Alluris", "712a1086c52b413da55f9b38588575d9", "1078510"),
            New EpicGamesBBDDJuego("Amnesia: A Machine for Pigs", "d7db33dfe7634d6b8a188c708f2caa3c", "239200"),
            New EpicGamesBBDDJuego("Amnesia: Rebirth", "f59de18db4dc445f88ffeff24d081234", "999220"),
            New EpicGamesBBDDJuego("Amnesia: The Dark Descent", "ece4c58603d04bcb97454be9a7492fa6", "57300"),
            New EpicGamesBBDDJuego("Among Trees", "dorado", Nothing),
            New EpicGamesBBDDJuego("Among Us", "963137e4c29d4c79a81323b8fab03a40", "945360"),
            New EpicGamesBBDDJuego("Ancestors: The Humankind Odyssey", "amaranth", "536270"),
            New EpicGamesBBDDJuego("Ancient Enemy", "a96de508ac71471fa05e7c1c695e3b5d", "993790"),
            New EpicGamesBBDDJuego("Anno 1404: History Edition", "f529f5a152014f65821eb900f1c54921", "1281630"),
            New EpicGamesBBDDJuego("Anno 1701: History Edition", "190415920d4a4e3f99043e57e8fabe60", Nothing),
            New EpicGamesBBDDJuego("Anno 1800", "oregano", Nothing),
            New EpicGamesBBDDJuego("Anno 2070 Complete Edition", "huchen", "48240"),
            New EpicGamesBBDDJuego("Anno 2205", "gulper", "375910"),
            New EpicGamesBBDDJuego("Anodyne 2: Return to Dust", "tanzanite", "877810"),
            New EpicGamesBBDDJuego("Ape Out", "coley", "447150"),
            New EpicGamesBBDDJuego("Aquanox Deep Descent", "c653d74ead8c4940bc121bcccbaf20cf", "254370"),
            New EpicGamesBBDDJuego("Arise: A Simple Story", "rail", "866140"),
            New EpicGamesBBDDJuego("ARK: Survival Evolved", "aafc587fbf654758802c8e41e4fb3255", "346110"),
            New EpicGamesBBDDJuego("art of rally", "01805192c8074820b1257fcfd97f2648", "550320"),
            New EpicGamesBBDDJuego("As Far As The Eye", "09d93e58c5694dc4a709d76887bcd61c", "1119700"),
            New EpicGamesBBDDJuego("Ashen", "wren", "649950"),
            New EpicGamesBBDDJuego("Ashwalkers", "464b25d9f4f9431a9faf2c299964c42c", "1273690"),
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
            New EpicGamesBBDDJuego("Battle Chasers: Nightwar", "c720c09efeba4597a5c24a98bcf62fa7", "451020"),
            New EpicGamesBBDDJuego("Bee Simulator", "spoonbill", "914750"),
            New EpicGamesBBDDJuego("Before We Leave", "salmon", "1073910"),
            New EpicGamesBBDDJuego("Before Your Eyes", "9a24b9e4c42445f7b739762530127d32", "1082430"),
            New EpicGamesBBDDJuego("Beyond Blue", "3a0cae9455844390ad00505a704d641e", "883360"),
            New EpicGamesBBDDJuego("Beyond Good & Evil", "52f83a6af963426aaee2d603030ef7c9", "15130"),
            New EpicGamesBBDDJuego("Beyond: Two Souls", "lavender", "960990"),
            New EpicGamesBBDDJuego("Big Pharma", "f23e1ec714a146648a4b330e777ee3a1", "344850"),
            New EpicGamesBBDDJuego("Blair Witch", "247a0f0f5803429eb3be2c06f3ea77ff", "1092660"),
            New EpicGamesBBDDJuego("Bloodroots", "pochard", "820540"),
            New EpicGamesBBDDJuego("Borderlands 2", "dodo", "49520"),
            New EpicGamesBBDDJuego("Borderlands 3", "catnip", "397540"),
            New EpicGamesBBDDJuego("Borderlands: The Pre-Sequel", "turkey", "261640"),
            New EpicGamesBBDDJuego("Breathedge", "0a20ccd3f1b3464da750a4dbf8c80d7c", "738520"),
            New EpicGamesBBDDJuego("Bridge Constructor: The Walking Dead", "998af0ab527c493baefb8049250c9a0e", "1336120"),
            New EpicGamesBBDDJuego("Bugsnax", "bonytail", Nothing),
            New EpicGamesBBDDJuego("Calico", "aa069bf2d1fb439cb44d659eda568c40", "1112890"),
            New EpicGamesBBDDJuego("Carcassonne: The Official Board Game", "thrush", "598810"),
            New EpicGamesBBDDJuego("Cardpocalypse", "duck", "904400"),
            New EpicGamesBBDDJuego("Carnival Games", "a45b88c3f65d49e68deb166786bf3670", "1249740"),
            New EpicGamesBBDDJuego("Carrion", "9faa3b0871e44b639d49a209f9405aab", "953490"),
            New EpicGamesBBDDJuego("Cartel Tycoon", "01a7f0655a164c1294df51a94cdec0e7", "1220140"),
            New EpicGamesBBDDJuego("Carto", "cb37006fed8c47db8bcb8a65a59d0f09", "1172450"),
            New EpicGamesBBDDJuego("CastleStorm 2", "dove", Nothing),
            New EpicGamesBBDDJuego("Cave Story+", "1dea8a6ddb544842a58e4b5c8675ff58", "200900"),
            New EpicGamesBBDDJuego("Celeste", "salt", "504230"),
            New EpicGamesBBDDJuego("Child of Light: Ultimate Edition", "3b8f18e6780547d9b2ee25fbfa29c913", Nothing),
            New EpicGamesBBDDJuego("Chivalry 2", "peppermint", Nothing),
            New EpicGamesBBDDJuego("Chronos: Before the Ashes", "8ab5702674e3478583c2c2b50f5b5eff", "967390"),
            New EpicGamesBBDDJuego("Cities: Skylines", "bcbc03d8812a44c18f41cf7d5f849265", "255710"),
            New EpicGamesBBDDJuego("City of Brass", "arrowroot", "301840"),
            New EpicGamesBBDDJuego("Close To The Sun", "silene", "968870"),
            New EpicGamesBBDDJuego("Conarium", "canary", "313780"),
            New EpicGamesBBDDJuego("Control Ultimate Edition", "calluna", "870780"),
            New EpicGamesBBDDJuego("Core", "a99769d95d8f400baad1f67ab5dfe508", Nothing),
            New EpicGamesBBDDJuego("Corruption 2029", "betta", Nothing),
            New EpicGamesBBDDJuego("Cosmic Express", "8745112cc56545dd8f6c92e3966dc86a", "583270"),
            New EpicGamesBBDDJuego("Costume Quest", "violetear", "115100"),
            New EpicGamesBBDDJuego("Costume Quest 2", "82a78a4dd6ef4eaa892707791b705073", "275180"),
            New EpicGamesBBDDJuego("Cozy Grove", "d6ca441db1c041f1b0ac142e0eea6312", "1458100"),
            New EpicGamesBBDDJuego("Crashlands", "afdf59e3dc8f40ec8fd887b5d3fcef23", "391730"),
            New EpicGamesBBDDJuego("Crayta", "a0a49d82e3f64c1b81873397a6e92f09", Nothing),
            New EpicGamesBBDDJuego("Creature in the Well", "a579a08e71b341e6af106dbd170e2ab2", "852300"),
            New EpicGamesBBDDJuego("CRSED: F.O.A.D.", "34eda78a6b24468f9fb70d73793bdaab", "884660"),
            New EpicGamesBBDDJuego("Crying Suns", "18fafa2d70d64831ab500a9d65ba9ab8", "873940"),
            New EpicGamesBBDDJuego("Crysis Remastered", "f1b8986afc9a4256a098cc5a4ebf5871", Nothing),
            New EpicGamesBBDDJuego("Curse of the Dead Gods", "6eefc4ed1f664a47ae398114f4a81a1d", "1123770"),
            New EpicGamesBBDDJuego("Cyanide & Happiness - Freakpocalypse", "a43520ea65e1429b86e49d2ab9a4e4dd", "869880"),
            New EpicGamesBBDDJuego("Cyberpunk 2077", "ginger", "1091500"),
            New EpicGamesBBDDJuego("Dandara: Trials of Fear Edition", "c35b9699c4e24c56976b5bd8eceba464", "612390"),
            New EpicGamesBBDDJuego("Dangerous Driving", "tansy", Nothing),
            New EpicGamesBBDDJuego("Darkest Dungeon", "36cbf259e631478eaac6ea244e55a709", "262060"),
            New EpicGamesBBDDJuego("Darksiders II Deathinitive Edition", "hoki", "388410"),
            New EpicGamesBBDDJuego("Darksiders III", "springbok", "606280"),
            New EpicGamesBBDDJuego("Darksiders Warmastered Edition", "hake", "462780"),
            New EpicGamesBBDDJuego("Dauntless", "jackal", Nothing),
            New EpicGamesBBDDJuego("Dead Cells", "ca0e1d19d3b640b39d8d20e966067872", "588650"),
            New EpicGamesBBDDJuego("Death Coming", "2333810845fd49a286baf29f9b58f9ae", "705120"),
            New EpicGamesBBDDJuego("Death Stranding", "boga", "1190460"),
            New EpicGamesBBDDJuego("Defense Grid: The Awakening", "a434dcb20f0d439b93aaa31dac9e3210", "18500"),
            New EpicGamesBBDDJuego("Democracy 4", "5e8da4f19dae455e948e568d8a0272bf", "1410710"),
            New EpicGamesBBDDJuego("Deponia: The Complete Journey", "03b7b25a77024cc0adf44777f791ffc4", "292910"),
            New EpicGamesBBDDJuego("Desperados III", "90f2d13d11e74ef29ac1af5c8b0b7730", "610370"),
            New EpicGamesBBDDJuego("Destroy All Humans!", "94232f38800f41b79b49243ada60ff24", "803330"),
            New EpicGamesBBDDJuego("Detroit: Become Human", "columbine", "1222140"),
            New EpicGamesBBDDJuego("Diabotical", "honeycreeper", Nothing),
            New EpicGamesBBDDJuego("Disaster Report 4: Summer Memories", "6684d2b2f9764f5c9c1c59de162c8a8e", "1060210"),
            New EpicGamesBBDDJuego("Disc Room", "bb026ee643614690b3f65f4f341bae4c", "1229580"),
            New EpicGamesBBDDJuego("Disco Elysium", "7334aba246154b63857435cb9c7eecd5", "632470"),
            New EpicGamesBBDDJuego("Donut County", "kestrel", "702670"),
            New EpicGamesBBDDJuego("Down in Bermuda", "1b3d52e6278749868913aa1cdd12e974", "1107300"),
            New EpicGamesBBDDJuego("DRAGON QUEST XI S: Echoes of an Elusive Age – Definitive Edition", "938603e109ab4b0b9304b2a8aac78280", "1295510"),
            New EpicGamesBBDDJuego("Drawful 2", "daisy", "442070"),
            New EpicGamesBBDDJuego("Dread Nautical", "opah", "1426900"),
            New EpicGamesBBDDJuego("Dungeons 3", "351fe5b32e22412d8fa41f4c7395fed1", "493900"),
            New EpicGamesBBDDJuego("ELEX", "f120f1dd840748deacc695d19a9022c5", "411300"),
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
            New EpicGamesBBDDJuego("Fell Seal: Arbiter's Mark", "b9787680fb524556be2d4bd05b25257e", "699170"),
            New EpicGamesBBDDJuego("Fez", "bluebird", "224760"),
            New EpicGamesBBDDJuego("Fights in Tight Spaces", "3e623cce500c49b69dd9a2926f474546", "1265820"),
            New EpicGamesBBDDJuego("Figment", "ed5e8d42b2ac461eb6f9176d163b9515", "493540"),
            New EpicGamesBBDDJuego("Flower", "yarrow", "966330"),
            New EpicGamesBBDDJuego("Football Manager 2020", "bf35243e8c3542e082bc7042e0592183", "1100600"),
            New EpicGamesBBDDJuego("Football Manager 2021", "6f5862ba65244cfe86490f253d64feb1", "1263850"),
            New EpicGamesBBDDJuego("For Honor", "sundrop", "304390"),
            New EpicGamesBBDDJuego("For The King", "discus", "527230"),
            New EpicGamesBBDDJuego("Foregone", "dab", "1000760"),
            New EpicGamesBBDDJuego("Fortnite", "fortnite", Nothing),
            New EpicGamesBBDDJuego("Freedom Fighters", "0d771750aa9042898ce100dbfb5efb1a", "1347780"),
            New EpicGamesBBDDJuego("Frostpunk", "b2e00fc16632475782a7730d1bd7cb60", "323190"),
            New EpicGamesBBDDJuego("FTL: Faster Than Light", "blowfish", "212680"),
            New EpicGamesBBDDJuego("Fuser", "2939f4752d4b4ace95a8e1b16e79d3f5", "1331440"),
            New EpicGamesBBDDJuego("Galactic Civilizations III", "5f1c66366b2c4a6496d535d88c56e6cf", "226860"),
            New EpicGamesBBDDJuego("Geneforge 1 - Mutagen", "caa2c69bf2dc40b2b883e4cbbf5b0ab2", "1424710"),
            New EpicGamesBBDDJuego("Genesis Alpha One Deluxe Edition", "puma", "712190"),
            New EpicGamesBBDDJuego("Genesis Noir", "7a2c377db40e4b5bb2143c5b220d5e7b", "735290"),
            New EpicGamesBBDDJuego("Genshin Impact", "41869934302e4b8cafac2d3c0e7c293d", Nothing),
            New EpicGamesBBDDJuego("Ghostbusters: The Video Game Remastered", "mint", "1449280"),
            New EpicGamesBBDDJuego("Ghostrunner", "ea8df71f923649a193ab1c1fded7e1b3", "1139900"),
            New EpicGamesBBDDJuego("GNOG", "penguin", "290510"),
            New EpicGamesBBDDJuego("Godfall", "carp", Nothing),
            New EpicGamesBBDDJuego("God's Trigger", "9bc4423d873845739cc99ab69b6bfbe9", "488730"),
            New EpicGamesBBDDJuego("Gods Will Fall", "69911638c74449d2a2651241be1b3ad4", "1243690"),
            New EpicGamesBBDDJuego("Going Under", "5f4a39950a1d49c3a3ebad181a6c05fa", "1154810"),
            New EpicGamesBBDDJuego("Golazo! Soccer League", "d29aec5e458544a288f8d9556ea63d56", "1431040"),
            New EpicGamesBBDDJuego("Gone Home", "flier", "232430"),
            New EpicGamesBBDDJuego("GoNNER", "emperor", "437570"),
            New EpicGamesBBDDJuego("Gorogoa", "meerkat", "557600"),
            New EpicGamesBBDDJuego("Grand Theft Auto V", "9d2d0eb64d5c44529cece33fe2a46482", "271590"),
            New EpicGamesBBDDJuego("Griftlands", "phlox", "601840"),
            New EpicGamesBBDDJuego("Hades", "min", "1145360"),
            New EpicGamesBBDDJuego("Halcyon 6: Starbase Commander", "b9e848fc5e844f4285b0624789476664", "371200"),
            New EpicGamesBBDDJuego("Hammerting", "60dc80f49cf34a479df2c823df30e9ac", "760650"),
            New EpicGamesBBDDJuego("Hand of Fate 2", "808f0dfbf3b84c2680793724d7f207bf", "456670"),
            New EpicGamesBBDDJuego("Haven", "271515884ce348a08ce4b7a92f4304d5", "983970"),
            New EpicGamesBBDDJuego("Heavy Rain", "aster", "960910"),
            New EpicGamesBBDDJuego("Hell is Other Demons", "5ade01bafec54a148024665ce978b2a4", "595790"),
            New EpicGamesBBDDJuego("Hello Neighbor", "ursus", "521890"),
            New EpicGamesBBDDJuego("Hello Neighbor Hide & Seek", "morpho", "960420"),
            New EpicGamesBBDDJuego("Hellpoint", "210733411fa44d5f8454a1bb435db3a9", "628670"),
            New EpicGamesBBDDJuego("Heroes & Generals WWII", "8836f84a700140bb86103556cd7db0d4", "227940"),
            New EpicGamesBBDDJuego("Hitchhiker - A Mystery Game", "15e071ccc4374a05a09f492595214f22", "1003120"),
            New EpicGamesBBDDJuego("HITMAN", "barbet", "236870"),
            New EpicGamesBBDDJuego("HITMAN 3", "f73a0557f7fc4ca08e3cb2c0e5dfb22b", Nothing),
            New EpicGamesBBDDJuego("Hob", "lyrebird", "404680"),
            New EpicGamesBBDDJuego("Horace", "palila", "629090"),
            New EpicGamesBBDDJuego("Horizon Chase Turbo", "bb406082b69a47208489d3616b22b5c2", "389140"),
            New EpicGamesBBDDJuego("Horizon Zero Dawn Complete Edition", "grunion", "1151640"),
            New EpicGamesBBDDJuego("Hue", "herring", "383270"),
            New EpicGamesBBDDJuego("Human Resource Machine", "basil", "375820"),
            New EpicGamesBBDDJuego("Huntdown", "337ffb9c2d624545be086e6ead40dbbe", "598550"),
            New EpicGamesBBDDJuego("Hyper Light Drifter", "parakeet", "257850"),
            New EpicGamesBBDDJuego("Hyper Scape", "77c79ade0d2346d3b2ded21ab645f5bd", Nothing),
            New EpicGamesBBDDJuego("HyperParasite", "d2878a802e6641abbf104f9cff71fd10", "838110"),
            New EpicGamesBBDDJuego("Hypnospace Outlaw", "e57ce7ebdd354ef9807393484aedf498", "844590"),
            New EpicGamesBBDDJuego("I Am Dead", "32d8f5e15ceb425e8d7d980bfa29db39", "951750"),
            New EpicGamesBBDDJuego("Idle Champions de Forgotten Realms", "40cb42e38c0b4a14a1bb133eb3291572", "627690"),
            New EpicGamesBBDDJuego("Industries of Titan", "protea", "427940"),
            New EpicGamesBBDDJuego("Immortals Fenyx Rising", "pheasant", Nothing),
            New EpicGamesBBDDJuego("InnerSpace", "almond", "347000"),
            New EpicGamesBBDDJuego("INSIDE", "marigold", "304430"),
            New EpicGamesBBDDJuego("Into The Breach", "blobfish", "590380"),
            New EpicGamesBBDDJuego("iRacing", "3dda7ecb990341c599d2554bb1783259", "266410"),
            New EpicGamesBBDDJuego("Iron Harvest", "2877ce04ee7c4c1c8ce4c7245875ed6c", "826630"),
            New EpicGamesBBDDJuego("Ironcast", "ac8f20a7931e4d63a1db4dc1267ec3d1", "327670"),
            New EpicGamesBBDDJuego("John Wick Hex", "vanilla", "1405790"),
            New EpicGamesBBDDJuego("Jotun: Valhalla Edition", "grouse", "323580"),
            New EpicGamesBBDDJuego("Journey", "lemur", "638230"),
            New EpicGamesBBDDJuego("Journey to the Savage Planet", "oleander", "973810"),
            New EpicGamesBBDDJuego("Jurassic World Evolution", "373a4372c20540aca7fdd880d27fa49a", "648350"),
            New EpicGamesBBDDJuego("Just Cause 4 Reloaded", "kakopo", "517630"),
            New EpicGamesBBDDJuego("Ken Follett's The Pillars of the Earth", "819985835fd54090845e3083e28b77bb", "234270"),
            New EpicGamesBBDDJuego("Kill it With Fire", "123be6a3d02647df8f09a7da3eab7568", "1179210"),
            New EpicGamesBBDDJuego("Killing Floor 2", "finch", "232090"),
            New EpicGamesBBDDJuego("Kine", "rose", "824570"),
            New EpicGamesBBDDJuego("Kingdom Come: Deliverance", "eel", "379430"),
            New EpicGamesBBDDJuego("KINGDOM HEARTS HD 1.5+2.5 ReMIX", "68c214c58f694ae88c2dab6f209b43e4", Nothing),
            New EpicGamesBBDDJuego("KINGDOM HEARTS HD 2.8 Final Chapter Prologue", "d1a8f7c478d4439b8c60a5808715dc05", Nothing),
            New EpicGamesBBDDJuego("KINGDOM HEARTS III + Re Mind", "fd711544a06543e0ab1b0808de334120", Nothing),
            New EpicGamesBBDDJuego("KINGDOM HEARTS Melody of Memory", "3cfe73c3c7ed41ad99f616a231a74202", Nothing),
            New EpicGamesBBDDJuego("Kingdom New Lands", "cacao", "496300"),
            New EpicGamesBBDDJuego("Kingdoms of Amalur Re-Reckoning", "b8aa8afb7da84da3a978425ec4b8e5cd", "1041720"),
            New EpicGamesBBDDJuego("Knight Squad 2", "a99e5b890bb143eaa149e0f827adc2b4", "1048660"),
            New EpicGamesBBDDJuego("Kosmokrats", "09f57ff642e54a37b24cd8d0ad94d038", "1204410"),
            New EpicGamesBBDDJuego("Last Day of June", "pumpkin", "635320"),
            New EpicGamesBBDDJuego("Layers of Fear", "cilantro", "391720"),
            New EpicGamesBBDDJuego("Layers of Fear 2", "473e24df09f843a1acc4aa16b01dae83", "1029890"),
            New EpicGamesBBDDJuego("Legend of Keepers", "4d1884fe90f441129722197ba0bb9f8e", "978520"),
            New EpicGamesBBDDJuego("LEGO Batman: The Videogame", "goldeneye", "21000"),
            New EpicGamesBBDDJuego("LEGO Batman 2: DC Super Heroes", "grackle", "213330"),
            New EpicGamesBBDDJuego("LEGO Batman 3: Beyond Gotham", "gull", "313690"),
            New EpicGamesBBDDJuego("Levelhead", "196ba0d44d914ef69499877e53fa500d", "792710"),
            New EpicGamesBBDDJuego("Lifeless Planet Premier Edition", "860a4feefe2a4f48905ae86c61d5db64", "261530"),
            New EpicGamesBBDDJuego("Limbo", "hazelnut", "48000"),
            New EpicGamesBBDDJuego("Little Inferno", "clover", "221260"),
            New EpicGamesBBDDJuego("Loop Hero", "f7a0ebb44f93430fb1c4388a395eba96", "1282730"),
            New EpicGamesBBDDJuego("Lost Words: Beyond the Page", "1d114dfdf40c4b5695c5d2cf6d4b590b", "599610"),
            New EpicGamesBBDDJuego("Lumberjack's Dynasty", "d9b73a137a1347728976719eb94221f3", "968970"),
            New EpicGamesBBDDJuego("Mafia: Definitive Edition", "kunzite", "1030840"),
            New EpicGamesBBDDJuego("Mafia II: Definitive Edition", "c070615314394e1ca8d4b66e5edf949b", "1030830"),
            New EpicGamesBBDDJuego("Mafia III: Definitive Edition", "7dd3049c1e4f47d3976b4ef55d07bbcc", "360430"),
            New EpicGamesBBDDJuego("Magic: Legends", "f65978f976a944bcac6a51c5ba0afbec", Nothing),
            New EpicGamesBBDDJuego("Magic The Gathering Arena", "stargazer", Nothing),
            New EpicGamesBBDDJuego("Maneater", "turtle", "629820"),
            New EpicGamesBBDDJuego("Manifold Garden", "lorikeet", "473950"),
            New EpicGamesBBDDJuego("MechWarrior 5: Mercenaries", "hoopoe", "784080"),
            New EpicGamesBBDDJuego("Medieval Dynasty", "d25a23bc9dd742b7a2c4745a3db7d456", "1129580"),
            New EpicGamesBBDDJuego("Merchant of the Skies", "0ef46109342d47669b36e5ec7e1c0546", "1040070"),
            New EpicGamesBBDDJuego("Metro 2033 Redux", "petunia", "286690"),
            New EpicGamesBBDDJuego("Metro Exodus", "snapdragon", "412020"),
            New EpicGamesBBDDJuego("Metro Last Light Redux", "speedwell", "287390"),
            New EpicGamesBBDDJuego("Might & Magic Chess Royale", "b141e42965ff431aa0e23bf3d5635942", Nothing),
            New EpicGamesBBDDJuego("Might & Magic Heroes III", "7173df2e97074defb66afb3764c88348", Nothing),
            New EpicGamesBBDDJuego("Might & Magic Heroes VII: Ultimate Edition", "f324cf34cd1a4a94901e003d14da37b1", "321960"),
            New EpicGamesBBDDJuego("Milky Way Prince – The Vampire Star", "97d90ab4704344e9b6f255994fee639c", "1302050"),
            New EpicGamesBBDDJuego("Minit", "petrel", "609490"),
            New EpicGamesBBDDJuego("Missile Command: Recharged", "fe014df1aa2c465aae88138c4307b11a", "1292010"),
            New EpicGamesBBDDJuego("Monkey Barrels", "82002e1b13b642e4a820623f4d92dda2", Nothing),
            New EpicGamesBBDDJuego("Monopoly PLUS", "hamlet", "562810"),
            New EpicGamesBBDDJuego("Monster Jam Steel Titans 2", "b1b97045976b4d959467a5cda33a2f5a", "1205480"),
            New EpicGamesBBDDJuego("Moonlighter", "eagle", "606150"),
            New EpicGamesBBDDJuego("Mortal Shell", "0055e45ce7654c55aade646467349e83", "1110910"),
            New EpicGamesBBDDJuego("MotoGP 21", "12aa686d0df0456884a73b976652012f", "1447000"),
            New EpicGamesBBDDJuego("Mount & Blade II: Bannerlord", "chickadee", "261550"),
            New EpicGamesBBDDJuego("MudRunner", "bulbul", "675010"),
            New EpicGamesBBDDJuego("Mundaun", "31b0ca9025cf4ed3a799947298cacbb1", "720350"),
            New EpicGamesBBDDJuego("Murder by Numbers", "2c3dd568cada4c229753f550a44dcf2b", "1140290"),
            New EpicGamesBBDDJuego("Mutant Year Zero: Road to Eden", "falcon", "760060"),
            New EpicGamesBBDDJuego("Mutazione", "1fe19232c0f7476a8e99fd8752e800c2", "1080750"),
            New EpicGamesBBDDJuego("My Time At Portia", "cobra", "666140"),
            New EpicGamesBBDDJuego("NBA 2K21", "639977eecfd2497c941b71af949b5067", "1225330"),
            New EpicGamesBBDDJuego("Neighbours back From Hell", "ada6f617bc3f4042a7f2f7533f3573e8", "1283190"),
            New EpicGamesBBDDJuego("Neon Abyss", "a26f991a5e6c4e9c9572fc200cbea47f", "788100"),
            New EpicGamesBBDDJuego("Neurodeck", "4198d26267224b35a2bc45107c902162", "1253860"),
            New EpicGamesBBDDJuego("Neverwinter", "87be9bd6707748888bce1f79b025c5dd", "109600"),
            New EpicGamesBBDDJuego("Next Up Hero", "sumac", "667810"),
            New EpicGamesBBDDJuego("New Super Lucky's Tale", "f7af594eebf542fc91dfc911f5f1e1d2", "1038300"),
            New EpicGamesBBDDJuego("Night in the Woods", "cd1b8a6e5b6c47369e2a1e2cf7b7f536", "481510"),
            New EpicGamesBBDDJuego("No Straight Roads", "raven", Nothing),
            New EpicGamesBBDDJuego("Nuclear Throne", "turaco", "242680"),
            New EpicGamesBBDDJuego("Obduction", "635e08e4b4824baabd24ef3cf941743c", "306760"),
            New EpicGamesBBDDJuego("Observation", "allium", "906100"),
            New EpicGamesBBDDJuego("Observer: System Redux", "96bd88a871c24768a7cf1b9b9fbc5aa5", "1386900"),
            New EpicGamesBBDDJuego("OCTOPATH TRAVELER", "ee5ef1c5dee24106b6e2b9080d85d088", "921570"),
            New EpicGamesBBDDJuego("Oddworld: New 'n' Tasty", "7c566548d24343e48151125ced4b494c", "314660"),
            New EpicGamesBBDDJuego("Oddworld: Soulstorm", "15ec9dd25ab34e109584db02cbcf4a45", Nothing),
            New EpicGamesBBDDJuego("Offworld Trading Company", "snapper", "271240"),
            New EpicGamesBBDDJuego("Old World", "nightjar", Nothing),
            New EpicGamesBBDDJuego("Olija", "8f05e107857042b2b11c6d3e09bb0c30", "1297330"),
            New EpicGamesBBDDJuego("Omen Of Sorrow", "daffodil", Nothing),
            New EpicGamesBBDDJuego("Ooblets", "ostrich", Nothing),
            New EpicGamesBBDDJuego("Operencia: The Stolen Sun", "lily", "985950"),
            New EpicGamesBBDDJuego("Orwell's Animal Farm", "2d2246bc1e8148a1a9afc34983891db4", "1398100"),
            New EpicGamesBBDDJuego("Outer Wilds", "starfish", "753640"),
            New EpicGamesBBDDJuego("Outriders", "bea62ac5091841f8a43bd20c3c7edfd3", "680420"),
            New EpicGamesBBDDJuego("Outward", "viola", "794260"),
            New EpicGamesBBDDJuego("Overcooked", "sage", "448510"),
            New EpicGamesBBDDJuego("Overcooked! 2", "potoo", "728880"),
            New EpicGamesBBDDJuego("Overpass", "sandpiper", "970840"),
            New EpicGamesBBDDJuego("Oxenfree", "hibiscus", "388880"),
            New EpicGamesBBDDJuego("Oxygen Not Included", "lotus", "457140"),
            New EpicGamesBBDDJuego("Paladins", "antbird", "444090"),
            New EpicGamesBBDDJuego("Panzer Corps 2", "993c77acdd424c7db4fb69782e1bd69f", "1072040"),
            New EpicGamesBBDDJuego("Paper Beast", "06efba7b35c6459cba1919c524c0d7fa", "1232570"),
            New EpicGamesBBDDJuego("Path of Exile", "9a05967bb86f48278f8626be42548985", "238960"),
            New EpicGamesBBDDJuego("Pathway", "8fceb562623c430db9bb6abf0549c43e", "546430"),
            New EpicGamesBBDDJuego("Phantasy Star Online 2", "6c227b0fac70445aae645f0d601dc5d2", "1056640"),
            New EpicGamesBBDDJuego("Phantom Brigade", "chili", "553540"),
            New EpicGamesBBDDJuego("Phoenix Point: Year One Edition", "iris", "839770"),
            New EpicGamesBBDDJuego("Pikuniku", "48619f5656da446abccb727b78cda644", "572890"),
            New EpicGamesBBDDJuego("Pillars of Eternity - Definitive Edition", "bcc75c246fe04e45b0c1f1c3fd52503a", "291650"),
            New EpicGamesBBDDJuego("Pine", "6d564ff21f9c45b7b782b7113ad60be8", "1042780"),
            New EpicGamesBBDDJuego("Poly Bridge 2", "03e51fc525b24b2ea873ac13c16b9ed7", "1062160"),
            New EpicGamesBBDDJuego("Port Royale 4", "dd4b77658e5546d882a9315b66d0a192", "1024650"),
            New EpicGamesBBDDJuego("Predator: Hunting Grounds", "boxfish", "1556200"),
            New EpicGamesBBDDJuego("Primordials of Amyrion", "c279ad508db0453fa99f1d1ebb698c80", "1316870"),
            New EpicGamesBBDDJuego("Production Line: Car factory simulation", "c041feb3a2e74fb9bc520ec93099a081", "591370"),
            New EpicGamesBBDDJuego("Pumpkin Jack", "9fef3b816031450da8ba85b23820cfbb", "1186640"),
            New EpicGamesBBDDJuego("Q.U.B.E. 2", "auk", "359100"),
            New EpicGamesBBDDJuego("R.B.I. Baseball 21", "74320c8cff734b858c4515b4d0dba2a1", "1462150"),
            New EpicGamesBBDDJuego("Rage 2", "ad3d0f08dd0841d8a1ba77d94ded4773", "548570"),
            New EpicGamesBBDDJuego("Railway Empire", "8cf7c6b964514532ad8284a376a517bf", "503940"),
            New EpicGamesBBDDJuego("Raji: An Ancient Epic", "e6dca9926c204374ab209d85a2c1203e", "730390"),
            New EpicGamesBBDDJuego("Rayman Legends", "anchovy", "242550"),
            New EpicGamesBBDDJuego("Rayman Origins", "5fde4f58b678403199be6ac6762a00db", "207490"),
            New EpicGamesBBDDJuego("ReadySet Heroes", "peacock", Nothing),
            New EpicGamesBBDDJuego("Rebel Galaxy", "weaver", "290300"),
            New EpicGamesBBDDJuego("Rebel Galaxy Outlaw", "rgo", "910830"),
            New EpicGamesBBDDJuego("Red Dead Redemption 2", "heather", "1174180"),
            New EpicGamesBBDDJuego("Relicta", "b4670484aae24db492f0b468a98fe361", "941570"),
            New EpicGamesBBDDJuego("Remnant: From the Ashes", "b4a0d2d15acb4db894a599b810297543", "617290"),
            New EpicGamesBBDDJuego("RemiLore: Lost Girl in the Lands of Lore", "465208a1b96b4077a938d83f287e6c01", "995240"),
            New EpicGamesBBDDJuego("RiME", "hydrangea", "493200"),
            New EpicGamesBBDDJuego("RimWorld", "12915f06bb3442eeb414813e74af7df3", "294100"),
            New EpicGamesBBDDJuego("Rising Storm 2: Vietnam", "tern", "418460"),
            New EpicGamesBBDDJuego("Rocket League", "sugar", Nothing),
            New EpicGamesBBDDJuego("Rogue Company", "pewee", Nothing),
            New EpicGamesBBDDJuego("Rogue Legacy 2", "bd35425c9548494082d002f36601ff45", "1253920"),
            New EpicGamesBBDDJuego("Rogue State Revolution", "0f00530809984268a13089d76f7ecb20", "1145340"),
            New EpicGamesBBDDJuego("RollerCoaster Tycoon 3: Complete Edition", "281a47e363284108b82bf05c1a612145", "1368820"),
            New EpicGamesBBDDJuego("RollerCoaster Tycoon Adventures", "canna", Nothing),
            New EpicGamesBBDDJuego("RUINER", "laridae", "464060"),
            New EpicGamesBBDDJuego("RUNE II: Decapitation Edition", "cosmos", "821290"),
            New EpicGamesBBDDJuego("Saint's Row The Third Remastered", "loon", "978300"),
            New EpicGamesBBDDJuego("Samurai Jack: Battle Through Time", "4fcc58f22bbb42a4a1ee0cc887c0836e", "1150590"),
            New EpicGamesBBDDJuego("SAMURAI SHODOWN", "1c78abcd467643f9ad58cc3a7d161983", "1342260"),
            New EpicGamesBBDDJuego("SAMURAI SHODOWN NEOGEO COLLECTION", "75553c71fa1744a4be89f71d5b862eae", "999660"),
            New EpicGamesBBDDJuego("Satisfactory", "crab", "526870"),
            New EpicGamesBBDDJuego("Saviors of Sapphire Wings & Strangers of Sword City Revisited", "6164c4b295bb43fe9e68291a7d14de0c", "1363840"),
            New EpicGamesBBDDJuego("Scarlet Hood and the Wicked Wood", "14f37208219e48c5b9eadbc9f455c77b", "1141120"),
            New EpicGamesBBDDJuego("Scavengers", "502bae648130454faa79bf1e7e741cbd", "1183940"),
            New EpicGamesBBDDJuego("Scott Pilgrim vs. The World: The Game", "37e2b68d76244e3e837ff6477d20b124", Nothing),
            New EpicGamesBBDDJuego("Scourgebringer", "bf363d9625a5406f904d925f3e613327", "1037020"),
            New EpicGamesBBDDJuego("Scrapnaut", "ab292d6c40d44e15a49cb45e83f19454", "1323900"),
            New EpicGamesBBDDJuego("Secret Government", "36ebdc7cf3584d048efa0921b54021ee", "946990"),
            New EpicGamesBBDDJuego("Shadow Complex", "vpr", Nothing),
            New EpicGamesBBDDJuego("Shadow Man Remastered", "785e6a44b50e40ab8c68a3f4dd6cddb0", "1413870"),
            New EpicGamesBBDDJuego("Shadow Tactics: Blades of the Shogun", "fangtooth", "418240"),
            New EpicGamesBBDDJuego("Shadowhand", "ef03775556cd46c1af5dcfcb98529455", "427490"),
            New EpicGamesBBDDJuego("Shadowrun Dragonfall - Director’s Cut", "5b41454974be4d5883056ba298e53675", "300550"),
            New EpicGamesBBDDJuego("Shadowrun: Hong Kong - Extended Edition", "41470cb5755440b8b55ec3f94351133a", "346940"),
            New EpicGamesBBDDJuego("Shadowrun Returns", "dc29cb42f32e4a17af1d68c715fa459c", "234650"),
            New EpicGamesBBDDJuego("Shady Part of Me", "08401ada27404be2834f28c7ef06910f", "1116580"),
            New EpicGamesBBDDJuego("Shakedown Hawaii", "plumeria", "598730"),
            New EpicGamesBBDDJuego("Shenmue III", "pepper", "878670"),
            New EpicGamesBBDDJuego("Sherlock Holmes: Crimes and Punishments", "0afb9d54dd3743a582b48b506466d3f8", "241260"),
            New EpicGamesBBDDJuego("Sherlock Holmes: The Devil's Daughter", "cinnamon", "350640"),
            New EpicGamesBBDDJuego("Sid Meier’s Civilization VI", "kinglet", "289070"),
            New EpicGamesBBDDJuego("Slime Rancher", "corydalis", "433340"),
            New EpicGamesBBDDJuego("Sludge Life", "morganite", "1144770"),
            New EpicGamesBBDDJuego("SMITE", "greenbul", "386360"),
            New EpicGamesBBDDJuego("Snowrunner", "mayflower", "1465360"),
            New EpicGamesBBDDJuego("Sokobond", "97c2ce083e47436dafa7536fd20162c9", "290260"),
            New EpicGamesBBDDJuego("Solitairica", "4c76beac4e8a4156aa8dfb9c6db09746", "463980"),
            New EpicGamesBBDDJuego("SOMA", "emu", "282140"),
            New EpicGamesBBDDJuego("Sonic Mania", "818447bb519b46d48d365d5753362796", "584400"),
            New EpicGamesBBDDJuego("South Park: The Fractured But Whole", "alewife", "488790"),
            New EpicGamesBBDDJuego("South Park: The Stick of Truth", "alligator", "213670"),
            New EpicGamesBBDDJuego("Spacebase Startopia", "cfc5878a838b46148f0cacdfb686256d", "840390"),
            New EpicGamesBBDDJuego("Spellbreak", "newt", "1399780"),
            New EpicGamesBBDDJuego("Spelldrifter", "a2b2ed0324c44902b9058e23dedc76e3", Nothing),
            New EpicGamesBBDDJuego("SpellForce 3: Fallen God", "36c9770807354d53a0d96d1b7862f746", "1154040"),
            New EpicGamesBBDDJuego("SpellForce 3: Versus Edition", "7b92cb9582b04a36b629321e848b12a1", "1416260"),
            New EpicGamesBBDDJuego("Spiritfarer", "740bb3cae62142d08e9fdf8262da352f", "972660"),
            New EpicGamesBBDDJuego("SpongeBob SquarePants: Battle for Bikini Bottom - Rehydrated", "f2304175954d40d2b583542251dda296", "969990"),
            New EpicGamesBBDDJuego("Star Renegades", "ae57424d9e8c4948a03ce00ebd4de8fd", "651670"),
            New EpicGamesBBDDJuego("Star Trek Online", "0fb6e06aacd14e88b1aaea8f54dd8525", "9900"),
            New EpicGamesBBDDJuego("Star Wars Battlefront: Ultimate Edition", "mtelbert", "1237980"),
            New EpicGamesBBDDJuego("Star Wars Battlefront II: Celebration Edition", "mtmassive", "1237950"),
            New EpicGamesBBDDJuego("Star Wars Jedi Fallen Order", "shoebill", "1172380"),
            New EpicGamesBBDDJuego("Star Wars Squadrons", "bobcat", "1222730"),
            New EpicGamesBBDDJuego("Startup Panic", "7003e758ed3a4790a36ad41c2d08f8b6", "1045610"),
            New EpicGamesBBDDJuego("State of Decay 2: Juggernaut Edition", "snoek", "495420"),
            New EpicGamesBBDDJuego("Steep", "barracuda", "460920"),
            New EpicGamesBBDDJuego("Stick It To The Man!", "goldfish", "251830"),
            New EpicGamesBBDDJuego("Stories Untold", "parsley", "558420"),
            New EpicGamesBBDDJuego("Stranded Deep", "02107cba432c4551a027d25d597adc49", "313120"),
            New EpicGamesBBDDJuego("Stranger Things 3: The Game", "0a697c1235fb4706a635cfa33f0306ec", "1097800"),
            New EpicGamesBBDDJuego("Subnautica", "jaguar", "264710"),
            New EpicGamesBBDDJuego("Subnautica: Below Zero", "foxglove", "848450"),
            New EpicGamesBBDDJuego("Sundered: Eldritch Edition", "moa", "535480"),
            New EpicGamesBBDDJuego("Sunless Sea", "2420b50453144c07b3b847fff941275d", "304650"),
            New EpicGamesBBDDJuego("Super Meat Boy", "buffalo", "40800"),
            New EpicGamesBBDDJuego("Super Meat Boy Forever", "moose", "581660"),
            New EpicGamesBBDDJuego("Super Squad", "66a2f64eae0641e0b4da935bb73a576a", "1124940"),
            New EpicGamesBBDDJuego("Superbrothers: Sword & Sworcery EP", "f6d328ca5be24fd585478d1477e1ea4d", "204060"),
            New EpicGamesBBDDJuego("SUPERHOT: Mind Control Delete", "7c9f2b7aa5a549e381b4e6aeff3779a1", "690040"),
            New EpicGamesBBDDJuego("Superliminal", "wigeon", "1049410"),
            New EpicGamesBBDDJuego("SuperMash", "nutmeg", "872720"),
            New EpicGamesBBDDJuego("Surgeon Simulator 2", "tanager", "774791"),
            New EpicGamesBBDDJuego("Surviving Mars", "ovenbird", "464920"),
            New EpicGamesBBDDJuego("Surviving the Aftermath", "muscovy", "684450"),
            New EpicGamesBBDDJuego("Tacoma", "flagfin", "343860"),
            New EpicGamesBBDDJuego("Tales from the Borderlands", "178c9c2b209a409e88a729ddb9aba7d2", "330830"),
            New EpicGamesBBDDJuego("Tales of the Neon Sea", "0dac2fd1f95240bda133d1f2fb27c705", "828740"),
            New EpicGamesBBDDJuego("Tetris Effect", "kiwi", "1003590"),
            New EpicGamesBBDDJuego("The Alto Collection", "hornbill", Nothing),
            New EpicGamesBBDDJuego("The Binding of Isaac: Repentance", "40f364fdf20e48068631043e9dc167eb", Nothing),
            New EpicGamesBBDDJuego("The Bridge", "sunbird", "204240"),
            New EpicGamesBBDDJuego("The Colonists", "ca22214a89694d94974a83d7e5c112b3", "677340"),
            New EpicGamesBBDDJuego("The Crew 2", "hermit", "646910"),
            New EpicGamesBBDDJuego("The Cycle", "azalea", "868270"),
            New EpicGamesBBDDJuego("The Dungeon Of Naheulbeuk: The Amulet Of Chaos", "02fac38ee2614c8ba276b1ea7c1acd7c", "970830"),
            New EpicGamesBBDDJuego("The End is Nigh", "statice", "583470"),
            New EpicGamesBBDDJuego("The Escapists", "peony", "298630"),
            New EpicGamesBBDDJuego("The Escapists 2", "fowl", "641990"),
            New EpicGamesBBDDJuego("The Fabled Woods", "9d3719023dcb41d0a888ff89fca89648", "1299480"),
            New EpicGamesBBDDJuego("The Fall", "daac7fe46e3647cb80530411d7ec1dc5", "290770"),
            New EpicGamesBBDDJuego("The Fall Part 2: Unbound", "f5739a2aa95841f7b4d2b8152bac5364", "510490"),
            New EpicGamesBBDDJuego("The First Tree", "cd98b47155654e1f9a9e84e60d0b49e4", "555150"),
            New EpicGamesBBDDJuego("The Flower Collectors", "d21030b8cc5b4466974b433207fac1dc", "1034750"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack", "feverfew", "331670"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 2", "lilac", "397460"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 3", "orchid", "434170"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 4", "snowdrop", "610180"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 5", "geranium", "774461"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 6", "astrapia", "1005300"),
            New EpicGamesBBDDJuego("The Jackbox Party Pack 7", "7fb6ce95c6d04a44a55fef16ea0db4c9", "1211630"),
            New EpicGamesBBDDJuego("The Last Campfire", "c713e12721894fcdbc59ad9ff3fd8a69", "990630"),
            New EpicGamesBBDDJuego("The Legend of Heroes: Trails of Cold Steel III", "54ec19e832aa4013a64ae853c5eb9fb0", "991270"),
            New EpicGamesBBDDJuego("The Legend of Heroes: Trails of Cold Steel IV", "e8a46db9786f45c9859e8af67e1251a0", "1198090"),
            New EpicGamesBBDDJuego("The Life And Suffering of Sir Brante", "6766ad3d4ba449d08caeb93d6ce3eef0", "1272160"),
            New EpicGamesBBDDJuego("The Lion's Song", "ee41ac4954314d18b18b8e7789c4e4eb", "437160"),
            New EpicGamesBBDDJuego("The Long Dark", "ed93b18355a84230938c705121c63661", "305620"),
            New EpicGamesBBDDJuego("The Medium", "bc72e23dc6494fb584a254ada099b362", "1293160"),
            New EpicGamesBBDDJuego("The Messenger", "jay", "764790"),
            New EpicGamesBBDDJuego("The Outer Worlds", "rosemallow", "578650"),
            New EpicGamesBBDDJuego("The Pathless", "geum", Nothing),
            New EpicGamesBBDDJuego("The Red Lantern", "guillemot", Nothing),
            New EpicGamesBBDDJuego("The Signifier: Director's Cut", "c666606976c047d2ae2374db6e8971ed", "1082930"),
            New EpicGamesBBDDJuego("The Sojourn", "shallots", "794960"),
            New EpicGamesBBDDJuego("The Solitaire Conspiracy", "162623ee6c524e41919d1efa24ce58ce", "1424980"),
            New EpicGamesBBDDJuego("The Spectrum Retreat", "7b8fb449c8d3404ba7eda9cd4da1401b", "763250"),
            New EpicGamesBBDDJuego("The Stanley Parable", "freesia", "221910"),
            New EpicGamesBBDDJuego("The Talos Principle", "bustard", "257510"),
            New EpicGamesBBDDJuego("The Telltale Batman Shadows Edition", "batfish", Nothing),
            New EpicGamesBBDDJuego("The Tenants", "80947c7cd1d7480284a66e292b1a559c", "1009560"),
            New EpicGamesBBDDJuego("The Textorcist: The Story of Ray Bibbia", "50d8518151d0498b83ff5d18a7bdb68b", "940680"),
            New EpicGamesBBDDJuego("The Uncertain: Last Quiet Day", "c3f618c8808244a381bfb4c41b1dd028", "406970"),
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
            New EpicGamesBBDDJuego("Through the Darkest of Times", "24a6998cc5ff4442b9e7620b4f8a4bc5", "1003090"),
            New EpicGamesBBDDJuego("Ticket to Ride", "towhee", "108200"),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Breakpoint", "saffron", Nothing),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Future Soldier Ultimate Edition", "e7471b6a7335415db9819ef7e7e77c29", Nothing),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Wildlands", "hyacinth", "460930"),
            New EpicGamesBBDDJuego("Tom Clancy's Rainbow Six Siege", "carnation", "359550"),
            New EpicGamesBBDDJuego("Tom Clancy's Splinter Cell", "5c344710714e42939e96f2e7519d2224", "13560"),
            New EpicGamesBBDDJuego("Tom Clancy's Splinter Cell Chaos Theory", "4bef8f2938c74f8597f512de38fc0afd", "13570"),
            New EpicGamesBBDDJuego("Tom Clancy's Splinter Cell Double Agent", "b678e4bde8cd4059919087cde99d966d", "13580"),
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
            New EpicGamesBBDDJuego("Trials Evolution: Gold Edition", "bc24707b365449748339d8c6f86ce7b8", "220160"),
            New EpicGamesBBDDJuego("Trials Fusion", "7a61f09916cf4d81a78cf796b182a002", "245490"),
            New EpicGamesBBDDJuego("Trials Rising", "argyle", "641080"),
            New EpicGamesBBDDJuego("Tropico 5", "8b5f1c51be3844bab51e2ee1089839f5", "245620"),
            New EpicGamesBBDDJuego("Tropico 6", "6f76563847a04e61be4f084717d456e0", "492720"),
            New EpicGamesBBDDJuego("Trover Saves the Universe", "sweetpea", "1051200"),
            New EpicGamesBBDDJuego("Twin Mirror", "58d0d56cb2f5475cbd89fed5beb44215", Nothing),
            New EpicGamesBBDDJuego("Tyranny - Gold Edition", "36b0e40890f147fbb1e3965f87369156", "362960"),
            New EpicGamesBBDDJuego("UNO", "hussar", "470220"),
            New EpicGamesBBDDJuego("Unreal Tournament", "ut", Nothing),
            New EpicGamesBBDDJuego("Untitled Goose Game", "flour", "837470"),
            New EpicGamesBBDDJuego("Valiant Hearts: The Great War", "f6496e154baa437cb4d9cae38a7e3cc5", "260230"),
            New EpicGamesBBDDJuego("Vampyr", "nautilus", "427290"),
            New EpicGamesBBDDJuego("Verdun", "38c0129b680e4843b4807b98bad67027", "242860"),
            New EpicGamesBBDDJuego("Warface", "8471bbbefe8d410fbee5483d860302fc", "291480"),
            New EpicGamesBBDDJuego("Warframe", "398965b67f314d31b0683b8ea11c93a4", "230410"),
            New EpicGamesBBDDJuego("Wargame: Red Dragon", "2cd446792405468e9e87f67649d864c2", "251060"),
            New EpicGamesBBDDJuego("Warhammer 40,000: Gladius - Relics of War", "da5b18cb1e7a452196c3142f2c1d7dd3", "489630"),
            New EpicGamesBBDDJuego("Watch Dogs", "jasper", "243470"),
            New EpicGamesBBDDJuego("Watch Dogs 2", "angelonia", "447040"),
            New EpicGamesBBDDJuego("Watch Dogs Legion", "hawk", Nothing),
            New EpicGamesBBDDJuego("Wattam", "lupine", "702680"),
            New EpicGamesBBDDJuego("Werewolf: The Apocalypse – Earthblood", "teal", Nothing),
            New EpicGamesBBDDJuego("What Remains of Edith Finch", "badger", "501300"),
            New EpicGamesBBDDJuego("What the Golf?", "stork", "785790"),
            New EpicGamesBBDDJuego("Wheels of Aurelia", "escolar", "508740"),
            New EpicGamesBBDDJuego("Where The Water Tastes Like Wine", "e8964b869b6849bea41eefec766cd665", "447120"),
            New EpicGamesBBDDJuego("Whispers of a Machine", "f98f2879f12f42bbbe767db90907d1ab", "631570"),
            New EpicGamesBBDDJuego("Wilmot's Warehouse", "9b40e3ffb4074f22a856a521be5ce858", "839870"),
            New EpicGamesBBDDJuego("Windbound", "a95bf4df6627431ca5baff8173c59635", "1162130"),
            New EpicGamesBBDDJuego("Wizards: Wand of Epicosity", "a19c886dab804ef0a0e095874c7e0d00", "772750"),
            New EpicGamesBBDDJuego("World of Goo", "anemone", "22000"),
            New EpicGamesBBDDJuego("World of Warships", "a79746038c6948558274065d24f3faa3", "552990"),
            New EpicGamesBBDDJuego("World War Z", "wombat", Nothing),
            New EpicGamesBBDDJuego("Wrath: Aeon of Ruin", "708e4a9716e24bdb846b26bb24aa2fb4", "1000410"),
            New EpicGamesBBDDJuego("WRC 8 FIA World Rally Championship", "woodpecker", "1004750"),
            New EpicGamesBBDDJuego("WRC 9 FIA World Rally Championship", "kagu", Nothing),
            New EpicGamesBBDDJuego("Yaga", "robin", "888530"),
            New EpicGamesBBDDJuego("Yes, Your Grace", "874d8bf57d9b4fef9eff995cee94d223", "1115690"),
            New EpicGamesBBDDJuego("Yooka-Laylee and the Impossible Lair", "duckbill", "846870"),
            New EpicGamesBBDDJuego("Zombi", "91b23d48ead64764b90a217a11baf209", "339230"),
            New EpicGamesBBDDJuego("Zombie Army 4: Dead War", "sparrow", "694280")
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