﻿Imports Newtonsoft.Json

Module EpicGamesBBDD

    'https://store-content.ak.epicgames.com/api/en-US/content/store
    'https://store-content.ak.epicgames.com/api/en-US/content/products/ + nameurl
    'https://store-content.ak.epicgames.com/api/content/productmapping

    'pendientes: arise-a-simple-story 
    '            assassins-creed-rogue
    '            assassins-creed-valhalla
    '            before-we-leave 
    '            chorus
    '            diabotical
    '            huntdown
    '            levelhead       
    '            monopoly-plus
    '            mount-and-blade-2
    '            old-world
    '            saturnalia
    '            sludge-life
    '            south-park-the-fractured-but-whole 
    '            south-park-the-stick-of-truth
    '            state-of-decay-2-juggernaut-edition
    '            the-crew-2
    '            the-witcher-3-wild-hunt
    '            tony-hawks-pro-skater-1-and-2
    '            trackmania-turbo
    '            uno

    Public Function Listado()
        Dim lista As New List(Of EpicGamesBBDDEntrada) From {
            New EpicGamesBBDDEntrada(">observer_", "tumeric", "observer", True),
            New EpicGamesBBDDEntrada("7 Billion Humans", "holly", "7-billion-humans", True),
            New EpicGamesBBDDEntrada("A Knights Quest", "cockatoo", "a-knights-quest", True),
            New EpicGamesBBDDEntrada("A Short Hike", "d6407c9e6fd54cb492b8c6635480d792", "a-short-hike", False),
            New EpicGamesBBDDEntrada("ABZU", "curry", "abzu", True),
            New EpicGamesBBDDEntrada("Afterparty", "adenium", "afterparty", True),
            New EpicGamesBBDDEntrada("Airborne Kingdom", "macaw", "airborne-kingdom", True),
            New EpicGamesBBDDEntrada("Alan Wake", "heron", "alan-wake", True),
            New EpicGamesBBDDEntrada("Alan Wake: American Nightmare", "condor", "alan-wake-american-nightmare", True),
            New EpicGamesBBDDEntrada("Amnesia: The Dark Descent", "ece4c58603d04bcb97454be9a7492fa6", "amnesia-the-dark-descent", True),
            New EpicGamesBBDDEntrada("Ancestors: The Humankind Odyssey", "amaranth", "ancestors", True),
            New EpicGamesBBDDEntrada("Anno 1800", "oregano", "anno-1800", True),
            New EpicGamesBBDDEntrada("Anodyne 2: Return to Dust", "tanzanite", "anodyne-2-return-to-dust", False),
            New EpicGamesBBDDEntrada("Ape Out", "coley", "ape-out", True),
            New EpicGamesBBDDEntrada("Ashen", "wren", "ashen", True),
            New EpicGamesBBDDEntrada("Assassin's Creed III: Remastered", "anise", "assassins-creed-3", True),
            New EpicGamesBBDDEntrada("Assassin's Creed Odyssey", "clary", "assassins-creed-odyssey", True),
            New EpicGamesBBDDEntrada("Assassin's Creed Origins", "camellia", "assassins-creed-origins", True),
            New EpicGamesBBDDEntrada("Assassin's Creed Syndicate", "albacore", "assassins-creed-syndicate", False),
            New EpicGamesBBDDEntrada("Atomicrops", "swan", "atomicrops", True),
            New EpicGamesBBDDEntrada("Auto Chess", "owl", "auto-chess", True),
            New EpicGamesBBDDEntrada("Axiom Verge", "puffin", "axiom-verge", True),
            New EpicGamesBBDDEntrada("Aztez", "grunt", "aztez", False),
            New EpicGamesBBDDEntrada("Bad North", "chives", "bad-north", True),
            New EpicGamesBBDDEntrada("Batman Arkham Asylum", "godwit", "batman-arkham-asylum", True),
            New EpicGamesBBDDEntrada("Batman Arkham City", "egret", "batman-arkham-city", True),
            New EpicGamesBBDDEntrada("Batman Arkham Knight", "cowbird", "batman-arkham-knight", True),
            New EpicGamesBBDDEntrada("Battle Breakers", "wex", "battle-breakers", True),
            New EpicGamesBBDDEntrada("Bee Simulator", "spoonbill", "bee-simulator", True),
            New EpicGamesBBDDEntrada("Beyond: Two Souls", "lavender", "beyond-two-souls", True),
            New EpicGamesBBDDEntrada("Bloodroots", "pochard", "bloodroots", True),
            New EpicGamesBBDDEntrada("Borderlands 3", "catnip", "borderlands-3", True),
            New EpicGamesBBDDEntrada("Carcassonne", "thrush", "carcassonne", False),
            New EpicGamesBBDDEntrada("Cardpocalypse", "duck", "cardpocalypse", True),
            New EpicGamesBBDDEntrada("Castle Storm 2", "dove", "castlestorm2", True),
            New EpicGamesBBDDEntrada("Celeste", "salt", "celeste", True),
            New EpicGamesBBDDEntrada("Chivalry 2", "peppermint", "chivalry-2", True),
            New EpicGamesBBDDEntrada("City of Brass", "arrowroot", "city-of-brass", True),
            New EpicGamesBBDDEntrada("Close To The Sun", "silene", "close-to-the-sun", True),
            New EpicGamesBBDDEntrada("Conarium", "canary", "conarium", True),
            New EpicGamesBBDDEntrada("Control", "calluna", "control", True),
            New EpicGamesBBDDEntrada("Corruption 2029", "betta", "corruption-2029", False),
            New EpicGamesBBDDEntrada("Costume Quest", "violetear", "costume-quest", True),
            New EpicGamesBBDDEntrada("Crashlands", "afdf59e3dc8f40ec8fd887b5d3fcef23", "crashlands", False),
            New EpicGamesBBDDEntrada("Cyberpunk 2077", "ginger", "cyberpunk-2077", True),
            New EpicGamesBBDDEntrada("Dangerous Driving", "tansy", "dangerous-driving", True),
            New EpicGamesBBDDEntrada("Darksiders II Deathinitive Edition", "hoki", "darksiders2", False),
            New EpicGamesBBDDEntrada("Darksiders III", "springbok", "darksiders3", True),
            New EpicGamesBBDDEntrada("Darksiders Warmastered Edition", "hake", "darksiders", False),
            New EpicGamesBBDDEntrada("Dauntless", "jackal", "dauntless", False),
            New EpicGamesBBDDEntrada("Death Coming", "2333810845fd49a286baf29f9b58f9ae", "death-coming", False),
            New EpicGamesBBDDEntrada("Death Stranding", "boga", "death-stranding", False),
            New EpicGamesBBDDEntrada("Detroit: Become Human", "columbine", "detroit-become-human", True),
            New EpicGamesBBDDEntrada("Donut County", "kestrel", "donut-county", True),
            New EpicGamesBBDDEntrada("Drawful 2", "daisy", "drawful-2", True),
            New EpicGamesBBDDEntrada("Enter the Gungeon", "garlic", "enter-the-gungeon", True),
            New EpicGamesBBDDEntrada("Everything", "pelican", "everything", True),
            New EpicGamesBBDDEntrada("Falcon Age", "parrot", "falcon-age", True),
            New EpicGamesBBDDEntrada("Far Cry 4", "tautog", "far-cry-4", True),
            New EpicGamesBBDDEntrada("Far Cry 5", "coriander", "far-cry-5", True),
            New EpicGamesBBDDEntrada("Far Cry New Dawn", "cumin", "far-cry-new-dawn", True),
            New EpicGamesBBDDEntrada("Far Cry Primal", "larkspur", "far-cry-primal", True),
            New EpicGamesBBDDEntrada("Farming Simulator 19", "stellula", "farming-simulator-19", False),
            New EpicGamesBBDDEntrada("Faster Than Light", "blowfish", "faster-than-light", True),
            New EpicGamesBBDDEntrada("Fez", "bluebird", "fez", True),
            New EpicGamesBBDDEntrada("Figment", "ed5e8d42b2ac461eb6f9176d163b9515", "figment", False),
            New EpicGamesBBDDEntrada("Flower", "yarrow", "flower", True),
            New EpicGamesBBDDEntrada("For Honor", "sundrop", "for-honor", True),
            New EpicGamesBBDDEntrada("For The King", "discus", "for-the-king", True),
            New EpicGamesBBDDEntrada("Foregone", "dab", "foregone", False),
            New EpicGamesBBDDEntrada("Fortnite", "fn", "fortnite", True),
            New EpicGamesBBDDEntrada("Genesis Alpha One", "puma", "genesis-alpha-one", False),
            New EpicGamesBBDDEntrada("Ghostbusters: The Video Game Remastered", "mint", "ghostbusters-the-video-game-remastered", True),
            New EpicGamesBBDDEntrada("GNOG", "penguin", "gnog", True),
            New EpicGamesBBDDEntrada("Gods and Monsters", "pheasant", "gods-and-monsters", True),
            New EpicGamesBBDDEntrada("Gone Home", "flier", "gone-home", False),
            New EpicGamesBBDDEntrada("Gorogoa", "meerkat", "gorogoa", True),
            New EpicGamesBBDDEntrada("Grand Theft Auto V", "9d2d0eb64d5c44529cece33fe2a46482", "grand-theft-auto-v", False),
            New EpicGamesBBDDEntrada("Griftlands", "phlox", "griftlands", True),
            New EpicGamesBBDDEntrada("Hades", "min", "hades", True),
            New EpicGamesBBDDEntrada("Heavy Rain", "aster", "heavy-rain", True),
            New EpicGamesBBDDEntrada("Hello Neighbor", "ursus", "hello-neighbor", True),
            New EpicGamesBBDDEntrada("Hello Neighbor Hide & Seek", "morpho", "hello-neighbor-hide-and-seek", True),
            New EpicGamesBBDDEntrada("Hob", "lyrebird", "hob", False),
            New EpicGamesBBDDEntrada("Horace", "palila", "horace", False),
            New EpicGamesBBDDEntrada("Human Resource Machine", "basil", "human-resource-machine", True),
            New EpicGamesBBDDEntrada("Hyper Light Drifter", "parakeet", "hyper-light-drifter", True),
            New EpicGamesBBDDEntrada("Industries of Titan", "protea", "industries-of-titan", True),
            New EpicGamesBBDDEntrada("Inside", "marigold", "inside", True),
            New EpicGamesBBDDEntrada("Into The Breach", "blobfish", "into-the-breach", True),
            New EpicGamesBBDDEntrada("Jackbox Party Pack", "feverfew", "jackbox-party-pack-1", True),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 2", "lilac", "jackbox-party-pack-2", True),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 3", "orchid", "jackbox-party-pack-3", True),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 4", "snowdrop", "jackbox-party-pack-4", True),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 5", "geranium", "jackbox-party-pack-5", True),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 6", "astrapia", "jackbox-party-pack-6", True),
            New EpicGamesBBDDEntrada("John Wick Hex", "vanilla", "johnwickhex", True),
            New EpicGamesBBDDEntrada("Jotun Valhalla Edition", "grouse", "jotun", False),
            New EpicGamesBBDDEntrada("Journey", "lemur", "journey", True),
            New EpicGamesBBDDEntrada("Journey to the Savage Planet", "oleander", "journey-to-the-savage-planet", True),
            New EpicGamesBBDDEntrada("Just Cause 4 Reloaded", "kakopo", "just-cause-4", True),
            New EpicGamesBBDDEntrada("Kine", "rose", "kine", True),
            New EpicGamesBBDDEntrada("Kingdom Come: Deliverance", "eel", "kingdom-come-deliverance", False),
            New EpicGamesBBDDEntrada("Kingdom New Lands", "cacao", "kingdom-new-lands", True),
            New EpicGamesBBDDEntrada("Last Day of June", "pumpkin", "last-day-of-june", True),
            New EpicGamesBBDDEntrada("Layers of Fear", "cilantro", "layers-of-fear", True),
            New EpicGamesBBDDEntrada("LEGO Batman: The Videogame", "goldeneye", "lego-batman", True),
            New EpicGamesBBDDEntrada("LEGO Batman 2: DC Super Heroes", "grackle", "lego-batman-2", True),
            New EpicGamesBBDDEntrada("LEGO Batman 3: Beyond Gotham", "gull", "lego-batman-3", True),
            New EpicGamesBBDDEntrada("Limbo", "hazelnut", "limbo", True),
            New EpicGamesBBDDEntrada("Little Inferno", "clover", "little-inferno", True),
            New EpicGamesBBDDEntrada("Magic The Gathering Arena", "stargazer", "mtg-arena", True),
            New EpicGamesBBDDEntrada("Maneater", "turtle", "maneater", True),
            New EpicGamesBBDDEntrada("Manifold Garden", "lorikeet", "manifold-garden", True),
            New EpicGamesBBDDEntrada("Mechwarrior 5", "hoopoe", "mechwarrior-5", True),
            New EpicGamesBBDDEntrada("Metro: 2033 Redux", "petunia", "metro-2033-redux", True),
            New EpicGamesBBDDEntrada("Metro Exodus", "snapdragon", "metro-exodus", True),
            New EpicGamesBBDDEntrada("Metro: Last Light Redux", "speedwell", "metro-last-light-redux", True),
            New EpicGamesBBDDEntrada("Might & Magic Chess Royale", "b141e42965ff431aa0e23bf3d5635942", "might-and-magic-chess-royale", False),
            New EpicGamesBBDDEntrada("Minit", "petrel", "minit", False),
            New EpicGamesBBDDEntrada("Moonlighter", "eagle", "moonlighter", True),
            New EpicGamesBBDDEntrada("Mutant Year Zero", "falcon", "mutant-year-zero", True),
            New EpicGamesBBDDEntrada("Mutazione", "1fe19232c0f7476a8e99fd8752e800c2", "mutazione", False),
            New EpicGamesBBDDEntrada("My Time At Portia", "cobra", "my-time-at-portia", True),
            New EpicGamesBBDDEntrada("No Straight Roads", "raven", "no-straight-roads", True),
            New EpicGamesBBDDEntrada("Nuclear Throne", "turaco", "nuclear-throne", True),
            New EpicGamesBBDDEntrada("Observation", "allium", "observation", True),
            New EpicGamesBBDDEntrada("Offworld Trading Company", "snapper", "offworld-trading-company", False),
            New EpicGamesBBDDEntrada("Omen Of Sorrow", "daffodil", "omen-of-sorrow", True),
            New EpicGamesBBDDEntrada("Ooblets", "ostrich", "ooblets", True),
            New EpicGamesBBDDEntrada("Operencia", "lily", "operencia", True),
            New EpicGamesBBDDEntrada("Outer Wilds", "starfish", "outerwilds", True),
            New EpicGamesBBDDEntrada("Outward", "viola", "outward", True),
            New EpicGamesBBDDEntrada("Overcooked", "sage", "overcooked", True),
            New EpicGamesBBDDEntrada("Overpass", "sandpiper", "overpass", False),
            New EpicGamesBBDDEntrada("Oxenfree", "hibiscus", "oxenfree", True),
            New EpicGamesBBDDEntrada("Oxygen Not Included", "lotus", "oxygen-not-included", True),
            New EpicGamesBBDDEntrada("Paladins", "antbird", "paladins", False),
            New EpicGamesBBDDEntrada("Pandemic", "thrasher", "pandemic", True),
            New EpicGamesBBDDEntrada("Paranoia: Happiness is Mandatory", "flamingo", "paranoia", True),
            New EpicGamesBBDDEntrada("Phantom Brigade", "chili", "phantom-brigade", True),
            New EpicGamesBBDDEntrada("Phoenix Point", "iris", "phoenix-point", True),
            New EpicGamesBBDDEntrada("Predator: Hunting Grounds", "boxfish", "predator-hunting-grounds", False),
            New EpicGamesBBDDEntrada("Q.U.B.E. 2", "auk", "q-u-b-e-2", False),
            New EpicGamesBBDDEntrada("Rainbow Six Quarantine", "trogon", "rainbow-six-quarantine", True),
            New EpicGamesBBDDEntrada("Rainbow Six Siege", "carnation", "rainbow-six-siege", True),
            New EpicGamesBBDDEntrada("Rayman Legends", "anchovy", "rayman-legends", True),
            New EpicGamesBBDDEntrada("ReadySet Heroes", "peacock", "readyset-heroes", True),
            New EpicGamesBBDDEntrada("Rebel Galaxy", "weaver", "rebel-galaxy", True),
            New EpicGamesBBDDEntrada("Rebel Galaxy Outlaw", "rgo", "rebel-galaxy-outlaw", True),
            New EpicGamesBBDDEntrada("Red Dead Redemption 2", "heather", "red-dead-redemption-2", True),
            New EpicGamesBBDDEntrada("RiME", "hydrangea", "rime", True),
            New EpicGamesBBDDEntrada("Rogue Company", "pewee", "rogue-company", True),
            New EpicGamesBBDDEntrada("RollerCoaster Tycoon Adventures", "canna", "rollercoaster-tycoon-adventures", True),
            New EpicGamesBBDDEntrada("RUINER", "laridae", "ruiner", True),
            New EpicGamesBBDDEntrada("Rune 2", "cosmos", "rune-2", True),
            New EpicGamesBBDDEntrada("Saint's Row The Third Remastered", "loon", "saints-row-the-third-remastered", False),
            New EpicGamesBBDDEntrada("SAMURAI SHODOWN", "1c78abcd467643f9ad58cc3a7d161983", "samurai-shodown-reboot", False),
            New EpicGamesBBDDEntrada("Satisfactory", "crab", "satisfactory", True),
            New EpicGamesBBDDEntrada("Shadow Complex", "vpr", "shadow-complex", True),
            New EpicGamesBBDDEntrada("Shadow Tactics: Blades of the Shogun", "fangtooth", "shadow-tactics", False),
            New EpicGamesBBDDEntrada("Shakedown Hawaii", "plumeria", "shakedown-hawaii", True),
            New EpicGamesBBDDEntrada("Shenmue 3", "pepper", "shenmue-3", True),
            New EpicGamesBBDDEntrada("Sherlock Holmes Crimes and Punishments", "0afb9d54dd3743a582b48b506466d3f8", "sherlock-holmes-crimes-and-punishments", False),
            New EpicGamesBBDDEntrada("Sherlock Holmes The Devil's Daughter", "cinnamon", "sherlock-holmes-the-devils-daughter", True),
            New EpicGamesBBDDEntrada("Slime Rancher", "corydalis", "slime-rancher", True),
            New EpicGamesBBDDEntrada("SMITE", "greenbul", "smite", False),
            New EpicGamesBBDDEntrada("Snowrunner", "mayflower", "snowrunner", False),
            New EpicGamesBBDDEntrada("Spellbreak", "newt", "spellbreak", True),
            New EpicGamesBBDDEntrada("SOMA", "emu", "soma", True),
            New EpicGamesBBDDEntrada("Star Wars Jedi Fallen Order", "shoebill", "star-wars-jedi-fallen-order", False),
            New EpicGamesBBDDEntrada("Steep", "barracuda", "steep", False),
            New EpicGamesBBDDEntrada("Stories Untold", "parsley", "stories-untold", True),
            New EpicGamesBBDDEntrada("Subnautica", "jaguar", "subnautica", True),
            New EpicGamesBBDDEntrada("Subnautica Below Zero", "foxglove", "subnautica-below-zero", True),
            New EpicGamesBBDDEntrada("Sundered Eldritch Edition", "moa", "sundered-eldritch-edition", False),
            New EpicGamesBBDDEntrada("Super Meat Boy", "buffalo", "super-meat-boy", True),
            New EpicGamesBBDDEntrada("Super Meat Boy Forever", "moose", "super-meat-boy-forever", True),
            New EpicGamesBBDDEntrada("Superliminal", "wigeon", "superliminal", True),
            New EpicGamesBBDDEntrada("SuperMash", "nutmeg", "supermash", True),
            New EpicGamesBBDDEntrada("Surgeon Simulator 2", "tanager", "surgeon-simulator-2", False),
            New EpicGamesBBDDEntrada("Surviving Mars", "ovenbird", "surviving-mars", True),
            New EpicGamesBBDDEntrada("Surviving the Aftermath", "muscovy", "surviving-the-aftermath", True),
            New EpicGamesBBDDEntrada("Tetris Effect", "kiwi", "tetris-effect", True),
            New EpicGamesBBDDEntrada("Tom Clancy's Ghost Recon Breakpoint", "saffron", "ghost-recon-breakpoint", True),
            New EpicGamesBBDDEntrada("Tom Clancy's Ghost Recon Wildlands", "hyacinth", "ghost-recon-wildlands", True),
            New EpicGamesBBDDEntrada("Tom Clancy's The Division 2", "impala", "the-division-2", True),
            New EpicGamesBBDDEntrada("The Bridge", "sunbird", "the-bridge", False),
            New EpicGamesBBDDEntrada("The Cycle", "azalea", "thecycle", True),
            New EpicGamesBBDDEntrada("The End is Nigh", "statice", "the-end-is-nigh", True),
            New EpicGamesBBDDEntrada("The Escapists", "peony", "the-escapists", True),
            New EpicGamesBBDDEntrada("The Eternal Cylinder", "oriole", "the-eternal-cylinder", True),
            New EpicGamesBBDDEntrada("The Messenger", "jay", "the-messenger", True),
            New EpicGamesBBDDEntrada("The Outer Worlds", "rosemallow", "the-outer-worlds", True),
            New EpicGamesBBDDEntrada("The Pathless", "geum", "the-pathless", True),
            New EpicGamesBBDDEntrada("The Red Lantern", "guillemot", "the-red-lantern", False),
            New EpicGamesBBDDEntrada("The Settlers", "magpie", "the-settlers", True),
            New EpicGamesBBDDEntrada("The Sinking City", "middlemist", "the-sinking-city", True),
            New EpicGamesBBDDEntrada("The Sojourn", "shallots", "the-sojourn", True),
            New EpicGamesBBDDEntrada("The Stanley Parable", "freesia", "the-stanley-parable", False),
            New EpicGamesBBDDEntrada("The Telltale Batman Shadows Edition", "batfish", "the-telltale-batman", False),
            New EpicGamesBBDDEntrada("The Walking Dead: Season One", "bloodroot", "walking-dead-season-one", True),
            New EpicGamesBBDDEntrada("The Walking Dead: Season Two", "buttercup", "walking-dead-season-two", True),
            New EpicGamesBBDDEntrada("The Walking Dead: A New Frontier", "begonia", "walking-dead-a-new-frontier", True),
            New EpicGamesBBDDEntrada("The Walking Dead: Final Season", "ocelot", "walking-dead-final-season", True),
            New EpicGamesBBDDEntrada("The Walking Dead: Michonne", "fennel", "walking-dead-michonne", True),
            New EpicGamesBBDDEntrada("The Walking Dead: The Telltale Definitive Series", "cuckoo", "walking-dead-definitive-series", True),
            New EpicGamesBBDDEntrada("The Witness", "magnolia", "the-witness", True),
            New EpicGamesBBDDEntrada("The Wolf Among Us", "cobbler", "the-wolf-among-us", False),
            New EpicGamesBBDDEntrada("This War of Mine", "cardinal", "this-war-of-mine", True),
            New EpicGamesBBDDEntrada("Thimbleweed Park", "tulip", "thimbleweed-park", True),
            New EpicGamesBBDDEntrada("Ticket to Ride", "towhee", "ticket-to-ride", True),
            New EpicGamesBBDDEntrada("Torchlight", "terragon", "torchlight", True),
            New EpicGamesBBDDEntrada("Tormentor X Punisher", "goby", "tormentor-x-punisher", True),
            New EpicGamesBBDDEntrada("Totally Accurate Battle Simulator", "driftfish", "totally-accurate-battle-simulator", True),
            New EpicGamesBBDDEntrada("Totally Reliable Delivery Service", "hoatzin", "totally-reliable-delivery-service", False),
            New EpicGamesBBDDEntrada("TowerFall Ascension", "bichir", "towerfall-ascension", False),
            New EpicGamesBBDDEntrada("Transistor", "dill", "transistor", True),
            New EpicGamesBBDDEntrada("Trials Rising", "argyle", "trials-rising", True),
            New EpicGamesBBDDEntrada("Trover Saves the Universe", "sweetpea", "trover-saves-the-universe", True),
            New EpicGamesBBDDEntrada("Unreal Tournament", "ut", "unreal-tournament", True),
            New EpicGamesBBDDEntrada("Untitled Goose Game", "flour", "untitled-goose-game", True),
            New EpicGamesBBDDEntrada("Vampire: The Masquerade - Bloodlines 2", "nemesia", "vampire-the-masquerade-bloodlines-2", False),
            New EpicGamesBBDDEntrada("Vampyr", "Nautilus", "vampyr", True),
            New EpicGamesBBDDEntrada("Watch Dogs", "jasper", "watch-dogs", False),
            New EpicGamesBBDDEntrada("Watch Dogs 2", "angelonia", "watch-dogs-2", True),
            New EpicGamesBBDDEntrada("Watch Dogs Legion", "hawk", "watch-dogs-legion", True),
            New EpicGamesBBDDEntrada("Wattam", "lupine", "wattam", True),
            New EpicGamesBBDDEntrada("What Remains of Edith Finch", "badger", "what-remains-of-edith-finch", True),
            New EpicGamesBBDDEntrada("What the Golf?", "stork", "what-the-golf", True),
            New EpicGamesBBDDEntrada("Wheels of Aurelia", "escolar", "wheels-of-aurelia", False),
            New EpicGamesBBDDEntrada("World of Goo", "anemone", "world-of-goo", True),
            New EpicGamesBBDDEntrada("World War Z", "wombat", "world-war-z", False),
            New EpicGamesBBDDEntrada("WRC 8", "woodpecker", "wrc-8", True),
            New EpicGamesBBDDEntrada("Yaga", "robin", "yaga", True),
            New EpicGamesBBDDEntrada("Yooka-Laylee and the Impossible Lair", "duckbill", "yooka-laylee-and-the-impossible-lair", True),
            New EpicGamesBBDDEntrada("Zombie Army 4: Dead War", "sparrow", "zombie-army-4-dead-war", True)
        }

        Return lista
    End Function

End Module

Public Class EpicGamesBBDDEntrada

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
    Public FondoVertical As String

    <JsonProperty("backgroundImageUrl")>
    Public FondoHorizontal As String

End Class

Public Class EpicGamesJuegoImagenesFuente

    <JsonProperty("src")>
    Public Url As String

End Class