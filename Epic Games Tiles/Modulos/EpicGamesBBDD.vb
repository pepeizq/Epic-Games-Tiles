Imports Newtonsoft.Json

Module EpicGamesBBDD

    'https://store-content.ak.epicgames.com/api/en-US/content/store
    'https://store-content.ak.epicgames.com/api/en-US/content/products/ + nameurl
    'https://store-content.ak.epicgames.com/api/content/productmapping

    'pendientes: alluris
    '            as-far-as-the-eye
    '            bugsnax
    '            chorus
    '            claire-de-lune
    '            demon-turf
    '            far-cry-6
    '            fuser
    '            godfall
    '            gravewood-high
    '            hitman-3
    '            iron-harvest
    '            jett-the-far-shore
    '            kena-bridge-of-spirits
    '            levelhead      
    '            primordials-of-amyrion
    '            recompile
    '            saturnalia
    '            sherlock-holmes-chapter-one
    '            star-wars-squadrons
    '            the-dungeon-of-naheulbeuk
    '            the-outlast-trials
    '            twin-mirror
    '            unexplored-2
    '            vampire-the-masquerade-swansong
    '            werewolf-the-apocalypse-earthblood

    Public Function Listado()
        Dim lista As New List(Of EpicGamesBBDDJuego) From {
            New EpicGamesBBDDJuego(">observer_", "tumeric", "observer", True),
            New EpicGamesBBDDJuego("20XX", "quail", "20xx", False),
            New EpicGamesBBDDJuego("3 Out of 10 Episode 1 Welcome to Shovelworks", "flounder", "3-out-of-10-ep-1", False),
            New EpicGamesBBDDJuego("3 Out of 10 Episode 2 Foundation 101", "1317e4e3b3ed40c289dde85b194347d3", "3-out-of-10-ep-2", False),
            New EpicGamesBBDDJuego("3 out of 10 Episode 3 Pivot Like A Champion", "d86f9cb568014746a15f66025dcc5733", "3-out-of-10-ep-3", False),
            New EpicGamesBBDDJuego("3 out of 10 Episode 4 Thank You For Being An Asset", "b2f57e24edcb4537bd76dff8b056a03e", "3-out-of-10-ep-4", False),
            New EpicGamesBBDDJuego("3 out of 10 Episode 5 The Rig Is Up!", "69c5351eacc540fd8850e12e90726e59", "3-out-of-10-ep-5", False),
            New EpicGamesBBDDJuego("7 Billion Humans", "holly", "7-billion-humans", True),
            New EpicGamesBBDDJuego("A Knights Quest", "cockatoo", "a-knights-quest", True),
            New EpicGamesBBDDJuego("A Short Hike", "d6407c9e6fd54cb492b8c6635480d792", "a-short-hike", False),
            New EpicGamesBBDDJuego("A Total War Saga: TROY", "11e598b192324994abce05bad4f81b50", "a-total-war-saga-troy", False),
            New EpicGamesBBDDJuego("ABZU", "curry", "abzu", True),
            New EpicGamesBBDDJuego("AER Memories of Old", "26b63c46de9e4dcc856b3c6b106b6777", "aer-memories-of-old", False),
            New EpicGamesBBDDJuego("Afterparty", "adenium", "afterparty", True),
            New EpicGamesBBDDJuego("Ageless", "de18a33d6e1f4001b9a3f4a50ef7d760", "ageless", False),
            New EpicGamesBBDDJuego("Airborne Kingdom", "macaw", "airborne-kingdom", False),
            New EpicGamesBBDDJuego("Alan Wake", "heron", "alan-wake", True),
            New EpicGamesBBDDJuego("Alan Wake: American Nightmare", "condor", "alan-wake-american-nightmare", True),
            New EpicGamesBBDDJuego("Amnesia: The Dark Descent", "ece4c58603d04bcb97454be9a7492fa6", "amnesia-the-dark-descent", True),
            New EpicGamesBBDDJuego("Ancestors: The Humankind Odyssey", "amaranth", "ancestors", True),
            New EpicGamesBBDDJuego("Anno 1404: History Edition", "f529f5a152014f65821eb900f1c54921", "anno-1404", False),
            New EpicGamesBBDDJuego("Anno 1701: History Edition", "190415920d4a4e3f99043e57e8fabe60", "anno-1701", False),
            New EpicGamesBBDDJuego("Anno 1800", "oregano", "anno-1800", True),
            New EpicGamesBBDDJuego("Anodyne 2: Return to Dust", "tanzanite", "anodyne-2-return-to-dust", False),
            New EpicGamesBBDDJuego("Ape Out", "coley", "ape-out", True),
            New EpicGamesBBDDJuego("Arise: A Simple Story", "rail", "arise-a-simple-story", False),
            New EpicGamesBBDDJuego("ARK: Survival Evolved", "aafc587fbf654758802c8e41e4fb3255", "ark", False),
            New EpicGamesBBDDJuego("Ashen", "wren", "ashen", True),
            New EpicGamesBBDDJuego("Assassin's Creed III: Remastered", "anise", "assassins-creed-3", False),
            New EpicGamesBBDDJuego("Assassin's Creed Odyssey", "clary", "assassins-creed-odyssey", False),
            New EpicGamesBBDDJuego("Assassin's Creed Origins", "camellia", "assassins-creed-origins", True),
            New EpicGamesBBDDJuego("Assassin's Creed Rogue", "wolffish", "assassins-creed-rogue", False),
            New EpicGamesBBDDJuego("Assassin's Creed Syndicate", "albacore", "assassins-creed-syndicate", False),
            New EpicGamesBBDDJuego("Assassin's Creed Valhalla", "965ccf8b2eba4f9381ef43183c08e205", "assassins-creed-valhalla", False),
            New EpicGamesBBDDJuego("Atomicrops", "swan", "atomicrops", False),
            New EpicGamesBBDDJuego("Auto Chess", "owl", "auto-chess", True),
            New EpicGamesBBDDJuego("Axiom Verge", "puffin", "axiom-verge", True),
            New EpicGamesBBDDJuego("Aztez", "grunt", "aztez", False),
            New EpicGamesBBDDJuego("Bad North", "chives", "bad-north", True),
            New EpicGamesBBDDJuego("Barony", "c98c4cd6d83a4524b4b22f13af95a104", "barony", False),
            New EpicGamesBBDDJuego("Batman Arkham Asylum", "godwit", "batman-arkham-asylum", True),
            New EpicGamesBBDDJuego("Batman Arkham City", "egret", "batman-arkham-city", True),
            New EpicGamesBBDDJuego("Batman Arkham Knight", "cowbird", "batman-arkham-knight", True),
            New EpicGamesBBDDJuego("Battle Breakers", "wex", "battle-breakers", True),
            New EpicGamesBBDDJuego("Bee Simulator", "spoonbill", "bee-simulator", True),
            New EpicGamesBBDDJuego("Before We Leave", "salmon", "before-we-leave", True),
            New EpicGamesBBDDJuego("Beyond Blue", "3a0cae9455844390ad00505a704d641e", "beyond-blue", False),
            New EpicGamesBBDDJuego("Beyond Good & Evil", "52f83a6af963426aaee2d603030ef7c9", "beyond-good-and-evil", False),
            New EpicGamesBBDDJuego("Beyond: Two Souls", "lavender", "beyond-two-souls", True),
            New EpicGamesBBDDJuego("Bloodroots", "pochard", "bloodroots", True),
            New EpicGamesBBDDJuego("Borderlands 2", "dodo", "borderlands-2", False),
            New EpicGamesBBDDJuego("Borderlands 3", "catnip", "borderlands-3", True),
            New EpicGamesBBDDJuego("Borderlands: The Pre-Sequel", "turkey", "borderlands-the-pre-sequel", False),
            New EpicGamesBBDDJuego("Carcassonne", "thrush", "carcassonne", True),
            New EpicGamesBBDDJuego("Cardpocalypse", "duck", "cardpocalypse", True),
            New EpicGamesBBDDJuego("Castle Storm 2", "dove", "castlestorm2", False),
            New EpicGamesBBDDJuego("Celeste", "salt", "celeste", False),
            New EpicGamesBBDDJuego("Child of Light: Ultimate Edition", "3b8f18e6780547d9b2ee25fbfa29c913", "child-of-light", False),
            New EpicGamesBBDDJuego("Chivalry 2", "peppermint", "chivalry-2", True),
            New EpicGamesBBDDJuego("City of Brass", "arrowroot", "city-of-brass", True),
            New EpicGamesBBDDJuego("Close To The Sun", "silene", "close-to-the-sun", False),
            New EpicGamesBBDDJuego("Conarium", "canary", "conarium", True),
            New EpicGamesBBDDJuego("Control", "calluna", "control", True),
            New EpicGamesBBDDJuego("Corruption 2029", "betta", "corruption-2029", False),
            New EpicGamesBBDDJuego("Costume Quest", "violetear", "costume-quest", True),
            New EpicGamesBBDDJuego("Crashlands", "afdf59e3dc8f40ec8fd887b5d3fcef23", "crashlands", False),
            New EpicGamesBBDDJuego("Cyberpunk 2077", "ginger", "cyberpunk-2077", True),
            New EpicGamesBBDDJuego("Dangerous Driving", "tansy", "dangerous-driving", True),
            New EpicGamesBBDDJuego("Darksiders II Deathinitive Edition", "hoki", "darksiders2", False),
            New EpicGamesBBDDJuego("Darksiders III", "springbok", "darksiders3", True),
            New EpicGamesBBDDJuego("Darksiders Warmastered Edition", "hake", "darksiders", False),
            New EpicGamesBBDDJuego("Dauntless", "jackal", "dauntless", False),
            New EpicGamesBBDDJuego("Death Coming", "2333810845fd49a286baf29f9b58f9ae", "death-coming", False),
            New EpicGamesBBDDJuego("Death Stranding", "boga", "death-stranding", False),
            New EpicGamesBBDDJuego("Desperados III", "90f2d13d11e74ef29ac1af5c8b0b7730", "desperados-3", False),
            New EpicGamesBBDDJuego("Destroy All Humans!", "94232f38800f41b79b49243ada60ff24", "destroy-all-humans", False),
            New EpicGamesBBDDJuego("Detroit: Become Human", "columbine", "detroit-become-human", True),
            New EpicGamesBBDDJuego("Diabotical", "honeycreeper", "diabotical", False),
            New EpicGamesBBDDJuego("Disco Elysium", "7334aba246154b63857435cb9c7eecd5", "disco-elysium", False),
            New EpicGamesBBDDJuego("Donut County", "kestrel", "donut-county", True),
            New EpicGamesBBDDJuego("Drawful 2", "daisy", "drawful-2", True),
            New EpicGamesBBDDJuego("Enter the Gungeon", "garlic", "enter-the-gungeon", True),
            New EpicGamesBBDDJuego("Everything", "pelican", "everything", False),
            New EpicGamesBBDDJuego("Falcon Age", "parrot", "falcon-age", True),
            New EpicGamesBBDDJuego("Far Cry", "c9d31937de5b45efb95b515b35a4960b", "far-cry", False),
            New EpicGamesBBDDJuego("Far Cry 2: Fortune's Edition", "3b78108a811d497db768899400edd842", "far-cry-2", False),
            New EpicGamesBBDDJuego("Far Cry 3", "hellebore", "far-cry-3", True),
            New EpicGamesBBDDJuego("Far Cry 4", "tautog", "far-cry-4", True),
            New EpicGamesBBDDJuego("Far Cry 5", "coriander", "far-cry-5", True),
            New EpicGamesBBDDJuego("Far Cry New Dawn", "cumin", "far-cry-new-dawn", True),
            New EpicGamesBBDDJuego("Far Cry Primal", "larkspur", "far-cry-primal", False),
            New EpicGamesBBDDJuego("Farming Simulator 19", "stellula", "farming-simulator-19", False),
            New EpicGamesBBDDJuego("Faster Than Light", "blowfish", "faster-than-light", True),
            New EpicGamesBBDDJuego("Fez", "bluebird", "fez", False),
            New EpicGamesBBDDJuego("Figment", "ed5e8d42b2ac461eb6f9176d163b9515", "figment", False),
            New EpicGamesBBDDJuego("Flower", "yarrow", "flower", True),
            New EpicGamesBBDDJuego("For Honor", "sundrop", "for-honor", False),
            New EpicGamesBBDDJuego("For The King", "discus", "for-the-king", True),
            New EpicGamesBBDDJuego("Foregone", "dab", "foregone", False),
            New EpicGamesBBDDJuego("Fortnite", "fortnite", "fortnite", True),
            New EpicGamesBBDDJuego("Genesis Alpha One", "puma", "genesis-alpha-one", False),
            New EpicGamesBBDDJuego("Ghostbusters: The Video Game Remastered", "mint", "ghostbusters-the-video-game-remastered", True),
            New EpicGamesBBDDJuego("GNOG", "penguin", "gnog", True),
            New EpicGamesBBDDJuego("Gods and Monsters", "pheasant", "gods-and-monsters", True),
            New EpicGamesBBDDJuego("God's Trigger", "9bc4423d873845739cc99ab69b6bfbe9", "gods-trigger", False),
            New EpicGamesBBDDJuego("Gone Home", "flier", "gone-home", False),
            New EpicGamesBBDDJuego("Gorogoa", "meerkat", "gorogoa", True),
            New EpicGamesBBDDJuego("Grand Theft Auto V", "9d2d0eb64d5c44529cece33fe2a46482", "grand-theft-auto-v", False),
            New EpicGamesBBDDJuego("Griftlands", "phlox", "griftlands", False),
            New EpicGamesBBDDJuego("Hades", "min", "hades", True),
            New EpicGamesBBDDJuego("Heavy Rain", "aster", "heavy-rain", True),
            New EpicGamesBBDDJuego("Hello Neighbor", "ursus", "hello-neighbor", False),
            New EpicGamesBBDDJuego("Hello Neighbor Hide & Seek", "morpho", "hello-neighbor-hide-and-seek", True),
            New EpicGamesBBDDJuego("Hellpoint", "210733411fa44d5f8454a1bb435db3a9", "hellpoint", False),
            New EpicGamesBBDDJuego("HITMAN", "barbet", "hitman", False),
            New EpicGamesBBDDJuego("Hob", "lyrebird", "hob", False),
            New EpicGamesBBDDJuego("Horace", "palila", "horace", False),
            New EpicGamesBBDDJuego("Horizon Zero Dawn Complete Edition", "grunion", "horizon-zero-dawn-complete-edition", False),
            New EpicGamesBBDDJuego("Hue", "herring", "hue", True),
            New EpicGamesBBDDJuego("Human Resource Machine", "basil", "human-resource-machine", True),
            New EpicGamesBBDDJuego("Huntdown", "337ffb9c2d624545be086e6ead40dbbe", "huntdown", False),
            New EpicGamesBBDDJuego("Hyper Light Drifter", "parakeet", "hyper-light-drifter", True),
            New EpicGamesBBDDJuego("Industries of Titan", "protea", "industries-of-titan", True),
            New EpicGamesBBDDJuego("Inside", "marigold", "inside", False),
            New EpicGamesBBDDJuego("Into The Breach", "blobfish", "into-the-breach", True),
            New EpicGamesBBDDJuego("Jackbox Party Pack", "feverfew", "jackbox-party-pack-1", True),
            New EpicGamesBBDDJuego("Jackbox Party Pack 2", "lilac", "jackbox-party-pack-2", True),
            New EpicGamesBBDDJuego("Jackbox Party Pack 3", "orchid", "jackbox-party-pack-3", True),
            New EpicGamesBBDDJuego("Jackbox Party Pack 4", "snowdrop", "jackbox-party-pack-4", True),
            New EpicGamesBBDDJuego("Jackbox Party Pack 5", "geranium", "jackbox-party-pack-5", True),
            New EpicGamesBBDDJuego("Jackbox Party Pack 6", "astrapia", "jackbox-party-pack-6", True),
            New EpicGamesBBDDJuego("John Wick Hex", "vanilla", "johnwickhex", True),
            New EpicGamesBBDDJuego("Jotun Valhalla Edition", "grouse", "jotun", False),
            New EpicGamesBBDDJuego("Journey", "lemur", "journey", True),
            New EpicGamesBBDDJuego("Journey to the Savage Planet", "oleander", "journey-to-the-savage-planet", True),
            New EpicGamesBBDDJuego("Just Cause 4 Reloaded", "kakopo", "just-cause-4", True),
            New EpicGamesBBDDJuego("Kill it With Fire", "123be6a3d02647df8f09a7da3eab7568", "kill-it-with-fire", False),
            New EpicGamesBBDDJuego("Killing Floor 2", "finch", "killing-floor-2", False),
            New EpicGamesBBDDJuego("Kine", "rose", "kine", True),
            New EpicGamesBBDDJuego("Kingdom Come: Deliverance", "eel", "kingdom-come-deliverance", False),
            New EpicGamesBBDDJuego("Kingdom New Lands", "cacao", "kingdom-new-lands", True),
            New EpicGamesBBDDJuego("Kingdoms of Amalur Re-Reckoning", "b8aa8afb7da84da3a978425ec4b8e5cd", "kingdoms-of-amalur-re-reckoning", False),
            New EpicGamesBBDDJuego("Last Day of June", "pumpkin", "last-day-of-june", True),
            New EpicGamesBBDDJuego("Layers of Fear", "cilantro", "layers-of-fear", True),
            New EpicGamesBBDDJuego("LEGO Batman: The Videogame", "goldeneye", "lego-batman", True),
            New EpicGamesBBDDJuego("LEGO Batman 2: DC Super Heroes", "grackle", "lego-batman-2", True),
            New EpicGamesBBDDJuego("LEGO Batman 3: Beyond Gotham", "gull", "lego-batman-3", True),
            New EpicGamesBBDDJuego("Lifeless Planet: Premier Edition", "860a4feefe2a4f48905ae86c61d5db64", "lifeless-planet-premier-edition", False),
            New EpicGamesBBDDJuego("Limbo", "hazelnut", "limbo", False),
            New EpicGamesBBDDJuego("Little Inferno", "clover", "little-inferno", True),
            New EpicGamesBBDDJuego("Mafia: Definitive Edition", "kunzite", "mafia-definitive-edition", False),
            New EpicGamesBBDDJuego("Mafia II: Definitive Edition", "c070615314394e1ca8d4b66e5edf949b", "mafia-ii-definitive-edition", False),
            New EpicGamesBBDDJuego("Mafia III: Definitive Edition", "7dd3049c1e4f47d3976b4ef55d07bbcc", "mafia-iii-definitive-edition", False),
            New EpicGamesBBDDJuego("Magic The Gathering Arena", "stargazer", "mtg-arena", False),
            New EpicGamesBBDDJuego("Maneater", "turtle", "maneater", True),
            New EpicGamesBBDDJuego("Manifold Garden", "lorikeet", "manifold-garden", False),
            New EpicGamesBBDDJuego("Mechwarrior 5", "hoopoe", "mechwarrior-5", True),
            New EpicGamesBBDDJuego("Metro: 2033 Redux", "petunia", "metro-2033-redux", True),
            New EpicGamesBBDDJuego("Metro Exodus", "b4a0d2d15acb4db894a599b810297543", "metro-exodus", True),
            New EpicGamesBBDDJuego("Metro: Last Light Redux", "speedwell", "metro-last-light-redux", True),
            New EpicGamesBBDDJuego("Might & Magic Chess Royale", "b141e42965ff431aa0e23bf3d5635942", "might-and-magic-chess-royale", False),
            New EpicGamesBBDDJuego("Might & Magic Heroes VII: Ultimate Edition", "f324cf34cd1a4a94901e003d14da37b1", "might-and-magic-heroes-7", False),
            New EpicGamesBBDDJuego("Milky Way Prince – The Vampire Star", "97d90ab4704344e9b6f255994fee639c", "milky-way-prince-the-vampire-star", False),
            New EpicGamesBBDDJuego("Minit", "petrel", "minit", False),
            New EpicGamesBBDDJuego("Missile Command: Recharged", "fe014df1aa2c465aae88138c4307b11a", "missile-command-recharged", False),
            New EpicGamesBBDDJuego("Monopoly PLUS", "hamlet", "monopoly-plus", False),
            New EpicGamesBBDDJuego("Moonlighter", "eagle", "moonlighter", True),
            New EpicGamesBBDDJuego("Mortal Shell", "0055e45ce7654c55aade646467349e83", "mortal-shell", False),
            New EpicGamesBBDDJuego("Mount & Blade II: Bannerlord", "chickadee", "mount-and-blade-2", False),
            New EpicGamesBBDDJuego("Mutant Year Zero", "falcon", "mutant-year-zero", True),
            New EpicGamesBBDDJuego("Mutazione", "1fe19232c0f7476a8e99fd8752e800c2", "mutazione", False),
            New EpicGamesBBDDJuego("My Time At Portia", "cobra", "my-time-at-portia", True),
            New EpicGamesBBDDJuego("Neon Abyss", "a26f991a5e6c4e9c9572fc200cbea47f", "neon-abyss", False),
            New EpicGamesBBDDJuego("Next Up Hero", "sumac", "next-up-hero", False),
            New EpicGamesBBDDJuego("New Super Lucky's Tale", "f7af594eebf542fc91dfc911f5f1e1d2", "new-super-luckys-tale", False),
            New EpicGamesBBDDJuego("No Straight Roads", "raven", "no-straight-roads", True),
            New EpicGamesBBDDJuego("Nuclear Throne", "turaco", "nuclear-throne", True),
            New EpicGamesBBDDJuego("Observation", "allium", "observation", True),
            New EpicGamesBBDDJuego("Offworld Trading Company", "snapper", "offworld-trading-company", False),
            New EpicGamesBBDDJuego("Old World", "nightjar", "old-world", False),
            New EpicGamesBBDDJuego("Omen Of Sorrow", "daffodil", "omen-of-sorrow", False),
            New EpicGamesBBDDJuego("Ooblets", "ostrich", "ooblets", False),
            New EpicGamesBBDDJuego("Operencia", "lily", "operencia", True),
            New EpicGamesBBDDJuego("Outer Wilds", "starfish", "outerwilds", True),
            New EpicGamesBBDDJuego("Outward", "viola", "outward", True),
            New EpicGamesBBDDJuego("Overcooked", "sage", "overcooked", True),
            New EpicGamesBBDDJuego("Overpass", "sandpiper", "overpass", False),
            New EpicGamesBBDDJuego("Oxenfree", "hibiscus", "oxenfree", True),
            New EpicGamesBBDDJuego("Oxygen Not Included", "lotus", "oxygen-not-included", True),
            New EpicGamesBBDDJuego("Paladins", "antbird", "paladins", False),
            New EpicGamesBBDDJuego("Pandemic", "thrasher", "pandemic", True),
            New EpicGamesBBDDJuego("Paranoia: Happiness is Mandatory", "flamingo", "paranoia", True),
            New EpicGamesBBDDJuego("Pathway", "8fceb562623c430db9bb6abf0549c43e", "pathway", False),
            New EpicGamesBBDDJuego("Phantom Brigade", "chili", "phantom-brigade", True),
            New EpicGamesBBDDJuego("Phoenix Point", "iris", "phoenix-point", True),
            New EpicGamesBBDDJuego("Poly Bridge 2", "03e51fc525b24b2ea873ac13c16b9ed7", "poly-bridge-2", False),
            New EpicGamesBBDDJuego("Predator: Hunting Grounds", "boxfish", "predator-hunting-grounds", False),
            New EpicGamesBBDDJuego("Q.U.B.E. 2", "auk", "q-u-b-e-2", False),
            New EpicGamesBBDDJuego("Railway Empire", "8cf7c6b964514532ad8284a376a517bf", "railway-empire", False),
            New EpicGamesBBDDJuego("Rainbow Six Quarantine", "trogon", "rainbow-six-quarantine", False),
            New EpicGamesBBDDJuego("Rainbow Six Siege", "carnation", "rainbow-six-siege", False),
            New EpicGamesBBDDJuego("Rayman Legends", "anchovy", "rayman-legends", True),
            New EpicGamesBBDDJuego("ReadySet Heroes", "peacock", "readyset-heroes", True),
            New EpicGamesBBDDJuego("Rebel Galaxy", "weaver", "rebel-galaxy", True),
            New EpicGamesBBDDJuego("Rebel Galaxy Outlaw", "rgo", "rebel-galaxy-outlaw", True),
            New EpicGamesBBDDJuego("Red Dead Redemption 2", "heather", "red-dead-redemption-2", True),
            New EpicGamesBBDDJuego("Relicta", "b4670484aae24db492f0b468a98fe361", "relicta", False),
            New EpicGamesBBDDJuego("Remnant: From the Ashes", "b4a0d2d15acb4db894a599b810297543", "remnant-from-the-ashes", False),
            New EpicGamesBBDDJuego("RiME", "hydrangea", "rime", True),
            New EpicGamesBBDDJuego("RimWorld", "12915f06bb3442eeb414813e74af7df3", "rimworld", False),
            New EpicGamesBBDDJuego("Rogue Company", "pewee", "rogue-company", False),
            New EpicGamesBBDDJuego("Rogue Legacy 2", "bd35425c9548494082d002f36601ff45", "rogue-legacy-2", False),
            New EpicGamesBBDDJuego("RollerCoaster Tycoon Adventures", "canna", "rollercoaster-tycoon-adventures", True),
            New EpicGamesBBDDJuego("RUINER", "laridae", "ruiner", True),
            New EpicGamesBBDDJuego("Rune 2", "cosmos", "rune-2", False),
            New EpicGamesBBDDJuego("Saint's Row The Third Remastered", "loon", "saints-row-the-third-remastered", False),
            New EpicGamesBBDDJuego("Samurai Jack: Battle Through Time", "4fcc58f22bbb42a4a1ee0cc887c0836e", "samurai-jack-battle-through-time", False),
            New EpicGamesBBDDJuego("SAMURAI SHODOWN", "1c78abcd467643f9ad58cc3a7d161983", "samurai-shodown-reboot", False),
            New EpicGamesBBDDJuego("SAMURAI SHODOWN NEOGEO COLLECTION", "75553c71fa1744a4be89f71d5b862eae", "samurai-shodown-neogeo-collection", False),
            New EpicGamesBBDDJuego("Satisfactory", "crab", "satisfactory", True),
            New EpicGamesBBDDJuego("Shadow Complex", "vpr", "shadow-complex", False),
            New EpicGamesBBDDJuego("Shadow Tactics: Blades of the Shogun", "fangtooth", "shadow-tactics", False),
            New EpicGamesBBDDJuego("Shadowrun Dragonfall - Director’s Cut", "5b41454974be4d5883056ba298e53675", "shadowrun-dragonfall", False),
            New EpicGamesBBDDJuego("Shadowrun Hong Kong", "41470cb5755440b8b55ec3f94351133a", "shadowrun-hong-kong", False),
            New EpicGamesBBDDJuego("Shadowrun Returns", "dc29cb42f32e4a17af1d68c715fa459c", "shadowrun-returns", False),
            New EpicGamesBBDDJuego("Shakedown Hawaii", "plumeria", "shakedown-hawaii", True),
            New EpicGamesBBDDJuego("Shenmue 3", "pepper", "shenmue-3", True),
            New EpicGamesBBDDJuego("Sherlock Holmes Crimes and Punishments", "0afb9d54dd3743a582b48b506466d3f8", "sherlock-holmes-crimes-and-punishments", False),
            New EpicGamesBBDDJuego("Sherlock Holmes The Devil's Daughter", "cinnamon", "sherlock-holmes-the-devils-daughter", True),
            New EpicGamesBBDDJuego("Sid Meier’s Civilization VI", "kinglet", "sid-meiers-civilization-vi", False),
            New EpicGamesBBDDJuego("Slime Rancher", "corydalis", "slime-rancher", True),
            New EpicGamesBBDDJuego("Sludge Life", "morganite", "sludge-life", False),
            New EpicGamesBBDDJuego("SMITE", "greenbul", "smite", False),
            New EpicGamesBBDDJuego("Snowrunner", "mayflower", "snowrunner", False),
            New EpicGamesBBDDJuego("SOMA", "emu", "soma", False),
            New EpicGamesBBDDJuego("South Park: The Fractured But Whole", "alewife", "south-park-the-fractured-but-whole", True),
            New EpicGamesBBDDJuego("South Park: The Stick of Truth", "alligator", "south-park-the-stick-of-truth", True),
            New EpicGamesBBDDJuego("Spellbreak", "newt", "spellbreak", False),
            New EpicGamesBBDDJuego("Spiritfarer", "740bb3cae62142d08e9fdf8262da352f", "spiritfarer", False),
            New EpicGamesBBDDJuego("SpongeBob SquarePants: Battle for Bikini Bottom - Rehydrated", "f2304175954d40d2b583542251dda296", "spongebob-squarepants-battle-for-bikini-bottom-rehydrated", False),
            New EpicGamesBBDDJuego("Star Wars Jedi Fallen Order", "shoebill", "star-wars-jedi-fallen-order", False),
            New EpicGamesBBDDJuego("State of Decay 2: Juggernaut Edition", "snoek", "state-of-decay-2-juggernaut-edition", False),
            New EpicGamesBBDDJuego("Steep", "barracuda", "steep", False),
            New EpicGamesBBDDJuego("Stick It To The Man!", "goldfish", "stick-it-to-the-man", False),
            New EpicGamesBBDDJuego("Stories Untold", "parsley", "stories-untold", True),
            New EpicGamesBBDDJuego("Stranger Things 3: The Game", "0a697c1235fb4706a635cfa33f0306ec", "stranger-things-3-the-game", False),
            New EpicGamesBBDDJuego("Subnautica", "jaguar", "subnautica", True),
            New EpicGamesBBDDJuego("Subnautica Below Zero", "foxglove", "subnautica-below-zero", True),
            New EpicGamesBBDDJuego("Sundered Eldritch Edition", "moa", "sundered-eldritch-edition", False),
            New EpicGamesBBDDJuego("Super Meat Boy", "buffalo", "super-meat-boy", False),
            New EpicGamesBBDDJuego("Super Meat Boy Forever", "moose", "super-meat-boy-forever", True),
            New EpicGamesBBDDJuego("Superbrothers: Sword & Sworcery EP", "f6d328ca5be24fd585478d1477e1ea4d", "superbrothers-sword-and-sworcery-ep", False),
            New EpicGamesBBDDJuego("SUPERHOT: Mind Control Delete", "7c9f2b7aa5a549e381b4e6aeff3779a1", "superhot-mind-control-delete", False),
            New EpicGamesBBDDJuego("Superliminal", "wigeon", "superliminal", False),
            New EpicGamesBBDDJuego("SuperMash", "nutmeg", "supermash", True),
            New EpicGamesBBDDJuego("Surgeon Simulator 2", "tanager", "surgeon-simulator-2", False),
            New EpicGamesBBDDJuego("Surviving Mars", "ovenbird", "surviving-mars", True),
            New EpicGamesBBDDJuego("Surviving the Aftermath", "muscovy", "surviving-the-aftermath", True),
            New EpicGamesBBDDJuego("Tacoma", "flagfin", "tacoma", False),
            New EpicGamesBBDDJuego("Tetris Effect", "kiwi", "tetris-effect", True),
            New EpicGamesBBDDJuego("The Alto Collection", "hornbill", "the-alto-collection", False),
            New EpicGamesBBDDJuego("The Bridge", "sunbird", "the-bridge", False),
            New EpicGamesBBDDJuego("The Crew 2", "hermit", "the-crew-2", True),
            New EpicGamesBBDDJuego("The Cycle", "azalea", "thecycle", False),
            New EpicGamesBBDDJuego("The End is Nigh", "statice", "the-end-is-nigh", True),
            New EpicGamesBBDDJuego("The Escapists", "peony", "the-escapists", True),
            New EpicGamesBBDDJuego("The Escapists 2", "fowl", "the-escapists-2", False),
            New EpicGamesBBDDJuego("The Eternal Cylinder", "oriole", "the-eternal-cylinder", True),
            New EpicGamesBBDDJuego("The Last Campfire", "c713e12721894fcdbc59ad9ff3fd8a69", "the-last-campfire", False),
            New EpicGamesBBDDJuego("The Messenger", "jay", "the-messenger", True),
            New EpicGamesBBDDJuego("The Outer Worlds", "rosemallow", "the-outer-worlds", True),
            New EpicGamesBBDDJuego("The Pathless", "geum", "the-pathless", True),
            New EpicGamesBBDDJuego("The Red Lantern", "guillemot", "the-red-lantern", False),
            New EpicGamesBBDDJuego("The Settlers", "magpie", "the-settlers", False),
            New EpicGamesBBDDJuego("The Sinking City", "middlemist", "the-sinking-city", False),
            New EpicGamesBBDDJuego("The Sojourn", "shallots", "the-sojourn", True),
            New EpicGamesBBDDJuego("The Stanley Parable", "freesia", "the-stanley-parable", False),
            New EpicGamesBBDDJuego("The Telltale Batman Shadows Edition", "batfish", "the-telltale-batman", False),
            New EpicGamesBBDDJuego("The Walking Dead: Season One", "bloodroot", "walking-dead-season-one", True),
            New EpicGamesBBDDJuego("The Walking Dead: Season Two", "buttercup", "walking-dead-season-two", False),
            New EpicGamesBBDDJuego("The Walking Dead: A New Frontier", "begonia", "walking-dead-a-new-frontier", False),
            New EpicGamesBBDDJuego("The Walking Dead: Final Season", "ocelot", "walking-dead-final-season", True),
            New EpicGamesBBDDJuego("The Walking Dead: Michonne", "fennel", "walking-dead-michonne", False),
            New EpicGamesBBDDJuego("The Walking Dead: The Telltale Definitive Series", "cuckoo", "walking-dead-definitive-series", True),
            New EpicGamesBBDDJuego("The Witcher 3: Wild Hunt - Game of the Year Edition", "725a22e15ed74735bb0d6a19f3cc82d0", "the-witcher-3-wild-hunt", False),
            New EpicGamesBBDDJuego("The Witness", "magnolia", "the-witness", True),
            New EpicGamesBBDDJuego("The Wolf Among Us", "cobbler", "the-wolf-among-us", False),
            New EpicGamesBBDDJuego("This War of Mine", "cardinal", "this-war-of-mine", True),
            New EpicGamesBBDDJuego("Thimbleweed Park", "tulip", "thimbleweed-park", True),
            New EpicGamesBBDDJuego("Ticket to Ride", "towhee", "ticket-to-ride", True),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Breakpoint", "saffron", "ghost-recon-breakpoint", False),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Future Soldier Ultimate Edition", "e7471b6a7335415db9819ef7e7e77c29", "ghost-recon-future-soldier", False),
            New EpicGamesBBDDJuego("Tom Clancy's Ghost Recon Wildlands", "hyacinth", "ghost-recon-wildlands", True),
            New EpicGamesBBDDJuego("Tom Clancy's The Division", "e4eb21a09dc049e982359b1e133ccebf", "the-division", False),
            New EpicGamesBBDDJuego("Tom Clancy's The Division 2", "impala", "the-division-2", True),
            New EpicGamesBBDDJuego("Tony Hawk's Pro Skater 1 + 2", "guppy", "tony-hawks-pro-skater-1-and-2", False),
            New EpicGamesBBDDJuego("Torchlight", "terragon", "torchlight", True),
            New EpicGamesBBDDJuego("Torchlight II", "8e425d507bd6473dbb927f0fea8ef4f6", "torchlight-2", False),
            New EpicGamesBBDDJuego("Tormentor X Punisher", "goby", "tormentor-x-punisher", True),
            New EpicGamesBBDDJuego("Totally Accurate Battle Simulator", "driftfish", "totally-accurate-battle-simulator", False),
            New EpicGamesBBDDJuego("Totally Reliable Delivery Service", "hoatzin", "totally-reliable-delivery-service", False),
            New EpicGamesBBDDJuego("TowerFall Ascension", "bichir", "towerfall-ascension", True),
            New EpicGamesBBDDJuego("Trackmania", "pigeon", "trackmania", False),
            New EpicGamesBBDDJuego("Trackmania Turbo", "a18915c48f584670bd236ce3031d63d9", "trackmania-turbo", False),
            New EpicGamesBBDDJuego("Transistor", "dill", "transistor", True),
            New EpicGamesBBDDJuego("Trials Rising", "argyle", "trials-rising", True),
            New EpicGamesBBDDJuego("Trover Saves the Universe", "sweetpea", "trover-saves-the-universe", True),
            New EpicGamesBBDDJuego("Uno", "hussar", "uno", True),
            New EpicGamesBBDDJuego("Unreal Tournament", "ut", "unreal-tournament", True),
            New EpicGamesBBDDJuego("Untitled Goose Game", "flour", "untitled-goose-game", True),
            New EpicGamesBBDDJuego("Valiant Hearts: The Great War", "f6496e154baa437cb4d9cae38a7e3cc5", "valiant-hearts", False),
            New EpicGamesBBDDJuego("Vampire: The Masquerade - Bloodlines 2", "nemesia", "vampire-the-masquerade-bloodlines-2", False),
            New EpicGamesBBDDJuego("Vampyr", "Nautilus", "vampyr", True),
            New EpicGamesBBDDJuego("Watch Dogs", "jasper", "watch-dogs", False),
            New EpicGamesBBDDJuego("Watch Dogs 2", "angelonia", "watch-dogs-2", True),
            New EpicGamesBBDDJuego("Watch Dogs Legion", "hawk", "watch-dogs-legion", True),
            New EpicGamesBBDDJuego("Wattam", "lupine", "wattam", True),
            New EpicGamesBBDDJuego("What Remains of Edith Finch", "badger", "what-remains-of-edith-finch", True),
            New EpicGamesBBDDJuego("What the Golf?", "stork", "what-the-golf", True),
            New EpicGamesBBDDJuego("Wheels of Aurelia", "escolar", "wheels-of-aurelia", False),
            New EpicGamesBBDDJuego("Where The Water Tastes Like Wine", "e8964b869b6849bea41eefec766cd665", "where-the-water-tastes-like-wine", False),
            New EpicGamesBBDDJuego("Wilmot's Warehouse", "9b40e3ffb4074f22a856a521be5ce858", "wilmots-warehouse", False),
            New EpicGamesBBDDJuego("Windbound", "a95bf4df6627431ca5baff8173c59635", "windbound", False),
            New EpicGamesBBDDJuego("Wizards: Wand of Epicosity", "a19c886dab804ef0a0e095874c7e0d00", "wizards-wand-of-epicosity", False),
            New EpicGamesBBDDJuego("World of Goo", "anemone", "world-of-goo", True),
            New EpicGamesBBDDJuego("World War Z", "wombat", "world-war-z", False),
            New EpicGamesBBDDJuego("WRC 8", "woodpecker", "wrc-8", True),
            New EpicGamesBBDDJuego("WRC 9 FIA World Rally Championship", "kagu", "wrc-9", False),
            New EpicGamesBBDDJuego("Yaga", "robin", "yaga", True),
            New EpicGamesBBDDJuego("Yooka-Laylee and the Impossible Lair", "duckbill", "yooka-laylee-and-the-impossible-lair", True),
            New EpicGamesBBDDJuego("Zombie Army 4: Dead War", "sparrow", "zombie-army-4-dead-war", True)
        }

        Return lista
    End Function

    Public Function ImagenesVertical()
        Dim lista As New List(Of EpicGamesBBDDJuegoImagenVertical) From {
            New EpicGamesBBDDJuegoImagenVertical("celeste", "https://i.imgur.com/Xq3qslq.jpg"),
            New EpicGamesBBDDJuegoImagenVertical("everything", "https://i.imgur.com/EB1Df4u.png"),
            New EpicGamesBBDDJuegoImagenVertical("far-cry-primal", "https://i.imgur.com/xhHKaI0.png"),
            New EpicGamesBBDDJuegoImagenVertical("fez", "https://i.imgur.com/sPcLPob.png"),
            New EpicGamesBBDDJuegoImagenVertical("for-honor", "https://i.imgur.com/cDjpz8u.png"),
            New EpicGamesBBDDJuegoImagenVertical("ghost-recon-future-soldier", "https://i.imgur.com/ymk3jhm.jpg"),
            New EpicGamesBBDDJuegoImagenVertical("gods-and-monsters", "https://i.imgur.com/iEfHJZE.png"),
            New EpicGamesBBDDJuegoImagenVertical("inside", "https://i.imgur.com/JGF2BoU.png"),
            New EpicGamesBBDDJuegoImagenVertical("kingdoms-of-amalur-re-reckoning", "https://i.imgur.com/IDpnNcw.jpg"),
            New EpicGamesBBDDJuegoImagenVertical("limbo", "https://i.imgur.com/VeIVNNp.png"),
            New EpicGamesBBDDJuegoImagenVertical("mtg-arena", "https://i.imgur.com/rr1ve2N.png"),
            New EpicGamesBBDDJuegoImagenVertical("manifold-garden", "https://i.imgur.com/JNOnuUh.png"),
            New EpicGamesBBDDJuegoImagenVertical("q-u-b-e-2", "https://i.imgur.com/ggyYknd.png"),
            New EpicGamesBBDDJuegoImagenVertical("railway-empire", "https://i.imgur.com/QUNWhbn.jpg"),
            New EpicGamesBBDDJuegoImagenVertical("rainbow-six-quarantine", "https://i.imgur.com/w6qfmVi.png"),
            New EpicGamesBBDDJuegoImagenVertical("rainbow-six-siege", "https://i.imgur.com/la0PQDv.png"),
            New EpicGamesBBDDJuegoImagenVertical("satisfactory", "https://i.imgur.com/EEcVDeD.png"),
            New EpicGamesBBDDJuegoImagenVertical("shadow-complex", "https://i.imgur.com/uRBa2W9.jpg"),
            New EpicGamesBBDDJuegoImagenVertical("super-meat-boy", "https://i.imgur.com/7zy5Z9D.png"),
            New EpicGamesBBDDJuegoImagenVertical("superliminal", "https://i.imgur.com/vLSCttq.png"),
            New EpicGamesBBDDJuegoImagenVertical("the-settlers", "https://i.imgur.com/Wq1AfRE.png"),
            New EpicGamesBBDDJuegoImagenVertical("walking-dead-michonne", "https://i.imgur.com/4u2hReb.jpg"),
            New EpicGamesBBDDJuegoImagenVertical("walking-dead-a-new-frontier", "https://i.imgur.com/syR6gzh.png"),
            New EpicGamesBBDDJuegoImagenVertical("walking-dead-season-two", "https://i.imgur.com/vT3iYA3.jpg"),
            New EpicGamesBBDDJuegoImagenVertical("vampyr", "https://i.imgur.com/th3la9W.png")
        }

        Return lista
    End Function

End Module

Public Class EpicGamesBBDDJuego

    Public Titulo As String
    Public ID As String
    Public Enlace As String
    Public Logo As Boolean

    Public Sub New(ByVal titulo As String, ByVal id As String, ByVal enlace As String, ByVal logo As Boolean)
        Me.Titulo = titulo
        Me.ID = id
        Me.Enlace = enlace
        Me.Logo = logo
    End Sub

End Class

Public Class EpicGamesBBDDJuegoImagenVertical

    Public ID As String
    Public Enlace As String

    Public Sub New(ByVal id As String, ByVal enlace As String)
        Me.ID = id
        Me.Enlace = enlace
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