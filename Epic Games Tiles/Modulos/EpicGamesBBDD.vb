Imports Newtonsoft.Json

Module EpicGamesBBDD

    'https://www.epicgames.com/store/es-ES/api/content/store
    'https://www.epicgames.com/store/es-ES/api/content/products/ + nameurl

    'pendientes: arise-a-simple-story 

    Public Function Listado()
        Dim lista As New List(Of EpicGamesBBDDEntrada) From {
            New EpicGamesBBDDEntrada(">observer_", "tumeric", "observer"),
            New EpicGamesBBDDEntrada("7 Billion Humans", "holly", "7-billion-humans"),
            New EpicGamesBBDDEntrada("A Knights Quest", "cockatoo", "a-knights-quest"),
            New EpicGamesBBDDEntrada("ABZU", "curry", "abzu"),
            New EpicGamesBBDDEntrada("Afterparty", "adenium", "afterparty"),
            New EpicGamesBBDDEntrada("Airborne Kingdom", "macaw", "airborne-kingdom"),
            New EpicGamesBBDDEntrada("Alan Wake", "heron", "alan-wake"),
            New EpicGamesBBDDEntrada("Alan Wake: American Nightmare", "condor", "alan-wake-american-nightmare"),
            New EpicGamesBBDDEntrada("Ancestors: The Humankind Odyssey", "amaranth", "ancestors"),
            New EpicGamesBBDDEntrada("Anno 1800", "oregano", "anno-1800"),
            New EpicGamesBBDDEntrada("Ashen", "wren", "ashen"),
            New EpicGamesBBDDEntrada("Assassin's Creed III: Remastered", "anise", "assassins-creed-3"),
            New EpicGamesBBDDEntrada("Assassin's Creed Odyssey", "clary", "assassins-creed-odyssey"),
            New EpicGamesBBDDEntrada("Atomicrops", "swan", "atomicrops"),
            New EpicGamesBBDDEntrada("Auto Chess", "owl", "auto-chess"),
            New EpicGamesBBDDEntrada("Axiom Verge", "puffin", "axiom-verge"),
            New EpicGamesBBDDEntrada("Batman Arkham Asylum", "godwit", "batman-arkham-asylum"),
            New EpicGamesBBDDEntrada("Batman Arkham City", "egret", "batman-arkham-city"),
            New EpicGamesBBDDEntrada("Batman Arkham Knight", "cowbird", "batman-arkham-knight"),
            New EpicGamesBBDDEntrada("Bee Simulator", "spoonbill", "bee-simulator"),
            New EpicGamesBBDDEntrada("Beyond: Two Souls", "lavender", "beyond-two-souls"),
            New EpicGamesBBDDEntrada("Borderlands 3", "catnip", "borderlands-3"),
            New EpicGamesBBDDEntrada("Cardpocalypse", "duck", "cardpocalypse"),
            New EpicGamesBBDDEntrada("Castle Storm 2", "dove", "castlestorm2"),
            New EpicGamesBBDDEntrada("Celeste", "salt", "celeste"),
            New EpicGamesBBDDEntrada("Chivalry 2", "peppermint", "chivalry-2"),
            New EpicGamesBBDDEntrada("City of Brass", "arrowroot", "city-of-brass"),
            New EpicGamesBBDDEntrada("Close To The Sun", "silene", "close-to-the-sun"),
            New EpicGamesBBDDEntrada("Conarium", "canary", "conarium"),
            New EpicGamesBBDDEntrada("Control", "calluna", "control"),
            New EpicGamesBBDDEntrada("Costume Quest", "violetear", "costume-quest"),
            New EpicGamesBBDDEntrada("Cyberpunk 2077", "ginger", "cyberpunk-2077"),
            New EpicGamesBBDDEntrada("Dangerous Driving", "tansy", "dangerous-driving"),
            New EpicGamesBBDDEntrada("Darksiders III", "springbok", "darksiders3"),
            New EpicGamesBBDDEntrada("Dauntless", "jackal", "dauntless"),
            New EpicGamesBBDDEntrada("Detroit: Become Human", "columbine", "detroit-become-human"),
            New EpicGamesBBDDEntrada("Donut County", "kestrel", "donut-county"),
            New EpicGamesBBDDEntrada("Drawful 2", "daisy", "drawful-2"),
            New EpicGamesBBDDEntrada("Enter the Gungeon", "garlic", "enter-the-gungeon"),
            New EpicGamesBBDDEntrada("Everything", "pelican", "everything"),
            New EpicGamesBBDDEntrada("Falcon Age", "parrot", "falcon-age"),
            New EpicGamesBBDDEntrada("Far Cry Primal", "larkspur", "far-cry-primal"),
            New EpicGamesBBDDEntrada("Fez", "bluebird", "fez"),
            New EpicGamesBBDDEntrada("Flower", "yarrow", "flower"),
            New EpicGamesBBDDEntrada("For Honor", "sundrop", "for-honor"),
            New EpicGamesBBDDEntrada("Fortnite", "fn", "fortnite"),
            New EpicGamesBBDDEntrada("Genesis Alpha One", "puma", "genesis-alpha-one"),
            New EpicGamesBBDDEntrada("Ghostbusters: The Video Game Remastered", "mint", "ghostbusters-the-video-game-remastered"),
            New EpicGamesBBDDEntrada("GNOG", "penguin", "gnog"),
            New EpicGamesBBDDEntrada("Gods and Monsters", "pheasant", "gods-and-monsters"),
            New EpicGamesBBDDEntrada("Gorogoa", "meerkat", "gorogoa"),
            New EpicGamesBBDDEntrada("Griftlands", "phlox", "griftlands"),
            New EpicGamesBBDDEntrada("Hades", "min", "hades"),
            New EpicGamesBBDDEntrada("Heavy Rain", "aster", "heavy-rain"),
            New EpicGamesBBDDEntrada("Hello Neighbor Hide & Seek", "morpho", "hello-neighbor-hide-and-seek"),
            New EpicGamesBBDDEntrada("Human Resource Machine", "basil", "human-resource-machine"),
            New EpicGamesBBDDEntrada("Hyper Light Drifter", "parakeet", "hyper-light-drifter"),
            New EpicGamesBBDDEntrada("Industries of Titan", "protea", "industries-of-titan"),
            New EpicGamesBBDDEntrada("Inside", "marigold", "inside"),
            New EpicGamesBBDDEntrada("Jackbox Party Pack", "feverfew", "jackbox-party-pack-1"),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 2", "lilac", "jackbox-party-pack-2"),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 3", "orchid", "jackbox-party-pack-3"),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 4", "snowdrop", "jackbox-party-pack-4"),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 5", "geranium", "jackbox-party-pack-5"),
            New EpicGamesBBDDEntrada("Jackbox Party Pack 6", "astrapia", "jackbox-party-pack-6"),
            New EpicGamesBBDDEntrada("John Wick Hex", "vanilla", "johnwickhex"),
            New EpicGamesBBDDEntrada("Journey", "lemur", "journey"),
            New EpicGamesBBDDEntrada("Journey to the Savage Planet", "oleander", "journey-to-the-savage-planet"),
            New EpicGamesBBDDEntrada("Kine", "rose", "kine"),
            New EpicGamesBBDDEntrada("Kingdom New Lands", "cacao", "kingdom-new-lands"),
            New EpicGamesBBDDEntrada("Last Day of June", "pumpkin", "last-day-of-june"),
            New EpicGamesBBDDEntrada("Layers of Fear", "cilantro", "layers-of-fear"),
            New EpicGamesBBDDEntrada("LEGO Batman: The Videogame", "goldeneye", "lego-batman"),
            New EpicGamesBBDDEntrada("LEGO Batman 2: DC Super Heroes", "grackle", "lego-batman-2"),
            New EpicGamesBBDDEntrada("LEGO Batman 3: Beyond Gotham", "gull", "lego-batman-3"),
            New EpicGamesBBDDEntrada("Limbo", "hazelnut", "limbo"),
            New EpicGamesBBDDEntrada("Little Inferno", "clover", "little-inferno"),
            New EpicGamesBBDDEntrada("Magic The Gathering Arena", "stargazer", "mtg-arena"),
            New EpicGamesBBDDEntrada("Maneater", "turtle", "maneater"),
            New EpicGamesBBDDEntrada("Manifold Garden", "lorikeet", "manifold-garden"),
            New EpicGamesBBDDEntrada("Mechwarrior 5", "hoopoe", "mechwarrior-5"),
            New EpicGamesBBDDEntrada("Metro: 2033 Redux", "petunia", "metro-2033-redux"),
            New EpicGamesBBDDEntrada("Metro Exodus", "snapdragon", "metro-exodus"),
            New EpicGamesBBDDEntrada("Metro: Last Light Redux", "speedwell", "metro-last-light-redux"),
            New EpicGamesBBDDEntrada("Moonlighter", "eagle", "moonlighter"),
            New EpicGamesBBDDEntrada("Minit", "petrel", "minit"),
            New EpicGamesBBDDEntrada("Mutant Year Zero", "falcon", "mutant-year-zero"),
            New EpicGamesBBDDEntrada("My Time At Portia", "cobra", "my-time-at-portia"),
            New EpicGamesBBDDEntrada("No Straight Roads", "raven", "no-straight-roads"),
            New EpicGamesBBDDEntrada("Nuclear Throne", "turaco", "nuclear-throne"),
            New EpicGamesBBDDEntrada("Observation", "allium", "observation"),
            New EpicGamesBBDDEntrada("Omen Of Sorrow", "daffodil", "omen-of-sorrow"),
            New EpicGamesBBDDEntrada("Ooblets", "ostrich", "ooblets"),
            New EpicGamesBBDDEntrada("Operencia", "lily", "operencia"),
            New EpicGamesBBDDEntrada("Outer Wilds", "starfish", "outerwilds"),
            New EpicGamesBBDDEntrada("Outward", "viola", "outward"),
            New EpicGamesBBDDEntrada("Overcooked", "sage", "overcooked"),
            New EpicGamesBBDDEntrada("Oxenfree", "hibiscus", "oxenfree"),
            New EpicGamesBBDDEntrada("Oxygen Not Included", "lotus", "oxygen-not-included"),
            New EpicGamesBBDDEntrada("Paranoia: Happiness is Mandatory", "flamingo", "paranoia"),
            New EpicGamesBBDDEntrada("Phantom Brigade", "chili", "phantom-brigade"),
            New EpicGamesBBDDEntrada("Phoenix Point", "iris", "phoenix-point"),
            New EpicGamesBBDDEntrada("Q.U.B.E. 2", "auk", "q-u-b-e-2"),
            New EpicGamesBBDDEntrada("Rainbow Six Quarantine", "trogon", "rainbow-six-quarantine"),
            New EpicGamesBBDDEntrada("Rainbow Six Siege", "carnation", "rainbow-six-siege"),
            New EpicGamesBBDDEntrada("ReadySet Heroes", "peacock", "readyset-heroes"),
            New EpicGamesBBDDEntrada("Rebel Galaxy", "weaver", "rebel-galaxy"),
            New EpicGamesBBDDEntrada("Rebel Galaxy Outlaw", "rgo", "rebel-galaxy-outlaw"),
            New EpicGamesBBDDEntrada("Red Dead Redemption 2", "heather", "red-dead-redemption-2"),
            New EpicGamesBBDDEntrada("RiME", "hydrangea", "rime"),
            New EpicGamesBBDDEntrada("Rogue Company", "pewee", "rogue-company"),
            New EpicGamesBBDDEntrada("RollerCoaster Tycoon Adventures", "canna", "rollercoaster-tycoon-adventures"),
            New EpicGamesBBDDEntrada("RUINER", "laridae", "ruiner"),
            New EpicGamesBBDDEntrada("Rune 2", "cosmos", "rune-2"),
            New EpicGamesBBDDEntrada("Satisfactory", "crab", "satisfactory"),
            New EpicGamesBBDDEntrada("Shadow Complex", "vpr", "shadow-complex"),
            New EpicGamesBBDDEntrada("Shakedown Hawaii", "plumeria", "shakedown-hawaii"),
            New EpicGamesBBDDEntrada("Shenmue 3", "pepper", "shenmue-3"),
            New EpicGamesBBDDEntrada("Sherlock Holmes The Devil's Daughter", "cinnamon", "sherlock-holmes-the-devils-daughter"),
            New EpicGamesBBDDEntrada("Slime Rancher", "corydalis", "slime-rancher"),
            New EpicGamesBBDDEntrada("Spellbreak", "newt", "spellbreak"),
            New EpicGamesBBDDEntrada("SOMA", "emu", "soma"),
            New EpicGamesBBDDEntrada("Stories Untold", "parsley", "stories-untold"),
            New EpicGamesBBDDEntrada("Subnautica", "jaguar", "subnautica"),
            New EpicGamesBBDDEntrada("Subnautica Below Zero", "foxglove", "subnautica-below-zero"),
            New EpicGamesBBDDEntrada("Super Meat Boy", "buffalo", "super-meat-boy"),
            New EpicGamesBBDDEntrada("Super Meat Boy Forever", "moose", "super-meat-boy-forever"),
            New EpicGamesBBDDEntrada("Superliminal", "wigeon", "superliminal"),
            New EpicGamesBBDDEntrada("Surviving Mars", "ovenbird", "surviving-mars"),
            New EpicGamesBBDDEntrada("Surviving the Aftermath", "muscovy", "surviving-the-aftermath"),
            New EpicGamesBBDDEntrada("Tetris Effect", "kiwi", "tetris-effect"),
            New EpicGamesBBDDEntrada("Tom Clancy's Ghost Recon Breakpoint", "saffron", "ghost-recon-breakpoint"),
            New EpicGamesBBDDEntrada("Tom Clancy's Ghost Recon Wildlands", "hyacinth", "ghost-recon-wildlands"),
            New EpicGamesBBDDEntrada("Tom Clancy's The Division 2", "impala", "the-division-2"),
            New EpicGamesBBDDEntrada("The Cycle", "azalea", "thecycle"),
            New EpicGamesBBDDEntrada("The End is Nigh", "statice", "the-end-is-nigh"),
            New EpicGamesBBDDEntrada("The Eternal Cylinder", "oriole", "the-eternal-cylinder"),
            New EpicGamesBBDDEntrada("The Outer Worlds", "rosemallow", "the-outer-worlds"),
            New EpicGamesBBDDEntrada("The Pathless", "geum", "the-pathless"),
            New EpicGamesBBDDEntrada("The Settlers", "magpie", "the-settlers"),
            New EpicGamesBBDDEntrada("The Sinking City", "middlemist", "the-sinking-city"),
            New EpicGamesBBDDEntrada("The Sojourn", "shallots", "the-sojourn"),
            New EpicGamesBBDDEntrada("The Walking Dead: Season One", "bloodroot", "walking-dead-season-one"),
            New EpicGamesBBDDEntrada("The Walking Dead: Season Two", "buttercup", "walking-dead-season-two"),
            New EpicGamesBBDDEntrada("The Walking Dead: A New Frontier", "begonia", "walking-dead-a-new-frontier"),
            New EpicGamesBBDDEntrada("The Walking Dead: Final Season", "ocelot", "walking-dead-final-season"),
            New EpicGamesBBDDEntrada("The Walking Dead: Michonne", "fennel", "walking-dead-michonne"),
            New EpicGamesBBDDEntrada("The Walking Dead: The Telltale Definitive Series", "cuckoo", "walking-dead-definitive-series"),
            New EpicGamesBBDDEntrada("The Witness", "magnolia", "the-witness"),
            New EpicGamesBBDDEntrada("This War of Mine", "cardinal", "this-war-of-mine"),
            New EpicGamesBBDDEntrada("Thimbleweed Park", "tulip", "thimbleweed-park"),
            New EpicGamesBBDDEntrada("Torchlight", "terragon", "torchlight"),
            New EpicGamesBBDDEntrada("Transistor", "dill", "transistor"),
            New EpicGamesBBDDEntrada("Trials Rising", "argyle", "trials-rising"),
            New EpicGamesBBDDEntrada("Trover Saves the Universe", "sweetpea", "trover-saves-the-universe"),
            New EpicGamesBBDDEntrada("Unreal Tournament", "ut", "unreal-tournament"),
            New EpicGamesBBDDEntrada("Untitled Goose Game", "flour", "untitled-goose-game"),
            New EpicGamesBBDDEntrada("Vampire: The Masquerade - Bloodlines 2", "nemesia", "vampire-the-masquerade-bloodlines-2"),
            New EpicGamesBBDDEntrada("Vampyr", "Nautilus", "vampyr"),
            New EpicGamesBBDDEntrada("Watch Dogs 2", "angelonia", "watch-dogs-2"),
            New EpicGamesBBDDEntrada("Watch Dogs Legion", "hawk", "watch-dogs-legion"),
            New EpicGamesBBDDEntrada("Wattam", "lupine", "wattam"),
            New EpicGamesBBDDEntrada("What Remains of Edith Finch", "badger", "what-remains-of-edith-finch"),
            New EpicGamesBBDDEntrada("What the Golf?", "stork", "what-the-golf"),
            New EpicGamesBBDDEntrada("World of Goo", "anemone", "world-of-goo"),
            New EpicGamesBBDDEntrada("World War Z", "wombat", "world-war-z"),
            New EpicGamesBBDDEntrada("WRC 8", "woodpecker", "wrc-8"),
            New EpicGamesBBDDEntrada("Yaga", "robin", "yaga"),
            New EpicGamesBBDDEntrada("Zombie Army 4: Dead War", "sparrow", "zombie-army-4-dead-war")
        }

        Return lista
    End Function

End Module

Public Class EpicGamesBBDDEntrada

    Public Titulo As String
    Public ID As String
    Public Enlace As String

    Public Sub New(ByVal titulo As String, ByVal id As String, ByVal enlace As String)
        Me.Titulo = titulo
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