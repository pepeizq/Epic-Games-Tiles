Module EpicGamesBBDD

    Public Function Listado()
        Dim lista As New List(Of EpicGamesBBDDEntrada) From {
            New EpicGamesBBDDEntrada("Afterparty", "adenium"),
            New EpicGamesBBDDEntrada("Ancestors: The Humankind Odyssey", "amaranth"),
            New EpicGamesBBDDEntrada("Anno 1800", "anno-1800"),
            New EpicGamesBBDDEntrada("Ashen", "wren"),
            New EpicGamesBBDDEntrada("Axiom Verge", "puffin"),
            New EpicGamesBBDDEntrada("Beyond: Two Souls", "lavender"),
            New EpicGamesBBDDEntrada("Close To The Sun", "silene"),
            New EpicGamesBBDDEntrada("Dangerous Driving", "tansy"),
            New EpicGamesBBDDEntrada("Darksiders III", "darksiders3"),
            New EpicGamesBBDDEntrada("Dauntless", "dauntless"),
            New EpicGamesBBDDEntrada("Detroit: Become Human", "columbine"),
            New EpicGamesBBDDEntrada("Donut County", "kestrel"),
            New EpicGamesBBDDEntrada("Drawful 2", "daisy"),
            New EpicGamesBBDDEntrada("Far Cry Primal", "larkspur"),
            New EpicGamesBBDDEntrada("Flower", "yarrow"),
            New EpicGamesBBDDEntrada("Fortnite", "fortnite"),
            New EpicGamesBBDDEntrada("Genesis Alpha One", "genesis-alpha-one"),
            New EpicGamesBBDDEntrada("Gorogoa", "meerkat"),
            New EpicGamesBBDDEntrada("Hades", "min"),
            New EpicGamesBBDDEntrada("Heavy Rain", "aster"),
            New EpicGamesBBDDEntrada("Hello Neighbor Hide & Seek", "helloneighbor"),
            New EpicGamesBBDDEntrada("Industries of Titan", "protea"),
            New EpicGamesBBDDEntrada("Journey", "journey"),
            New EpicGamesBBDDEntrada("Journey to the Savage Planet", "lemur"),
            New EpicGamesBBDDEntrada("Kine", "rose"),
            New EpicGamesBBDDEntrada("Maneater", "maneater"),
            New EpicGamesBBDDEntrada("Metro Exodus", "snapdragon"),
            New EpicGamesBBDDEntrada("My Time At Portia", "cobra"),
            New EpicGamesBBDDEntrada("Observation", "allium"),
            New EpicGamesBBDDEntrada("Operencia", "lily"),
            New EpicGamesBBDDEntrada("Outer Wilds", "Outerwilds"),
            New EpicGamesBBDDEntrada("Outward", "viola"),
            New EpicGamesBBDDEntrada("Oxenfree", "hibiscus"),
            New EpicGamesBBDDEntrada("Oxygen Not Included", "lotus"),
            New EpicGamesBBDDEntrada("Phoenix Point", "iris"),
            New EpicGamesBBDDEntrada("Rebel Galaxy Outlaw", "rgo"),
            New EpicGamesBBDDEntrada("RollerCoaster Tycoon Adventures", "roller-coaster-tycoon-adventures-copy"),
            New EpicGamesBBDDEntrada("Satisfactory", "crab"),
            New EpicGamesBBDDEntrada("Shadow Complex", "shadow-complex"),
            New EpicGamesBBDDEntrada("Shakedown - Hawaii", "plumeria"),
            New EpicGamesBBDDEntrada("Slime Rancher", "corydalis"),
            New EpicGamesBBDDEntrada("Spellbreak", "newt"),
            New EpicGamesBBDDEntrada("Subnautica", "jaguar"),
            New EpicGamesBBDDEntrada("Subnautica Below Zero", "subnautica-below-zero"),
            New EpicGamesBBDDEntrada("Super Meat Boy", "buffalo"),
            New EpicGamesBBDDEntrada("Super Meat Boy Forever", "smbf"),
            New EpicGamesBBDDEntrada("Tom Clancy's Ghost Recon Wildlands", "hyacinth"),
            New EpicGamesBBDDEntrada("The Cycle", "thecycle"),
            New EpicGamesBBDDEntrada("The Division 2", "tctd2"),
            New EpicGamesBBDDEntrada("The Jackbox Party Pack", "feverfew"),
            New EpicGamesBBDDEntrada("The Jackbox Party Pack 2", "lilac"),
            New EpicGamesBBDDEntrada("The Jackbox Party Pack 3", "orchid"),
            New EpicGamesBBDDEntrada("The Jackbox Party Pack 4", "snowdrop"),
            New EpicGamesBBDDEntrada("The Jackbox Party Pack 5", "geranium"),
            New EpicGamesBBDDEntrada("The Outer Worlds", "rosemallow"),
            New EpicGamesBBDDEntrada("The Sinking City", "middlemist"),
            New EpicGamesBBDDEntrada("The Walking Dead: Season One", "bloodroot"),
            New EpicGamesBBDDEntrada("The Walking Dead: Season Two", "buttercup"),
            New EpicGamesBBDDEntrada("The Walking Dead: A New Frontier", "begonia"),
            New EpicGamesBBDDEntrada("The Walking Dead: Final Season", "walking-dead-final-season"),
            New EpicGamesBBDDEntrada("The Walking Dead: Michonne", "fennel"),
            New EpicGamesBBDDEntrada("The Witness", "magnolia"),
            New EpicGamesBBDDEntrada("Thimbleweed Park", "tulip"),
            New EpicGamesBBDDEntrada("Transistor", "dill"),
            New EpicGamesBBDDEntrada("Trover Saves the Universe", "sweetpea"),
            New EpicGamesBBDDEntrada("Unreal Tournament", "UnrealTournamentDev"),
            New EpicGamesBBDDEntrada("Vampire: The Masquerade - Bloodlines 2", "nemesia"),
            New EpicGamesBBDDEntrada("Vampyr", "Nautilus"),
            New EpicGamesBBDDEntrada("Watch Dogs 2", "angelonia"),
            New EpicGamesBBDDEntrada("What Remains of Edith Finch", "badger"),
            New EpicGamesBBDDEntrada("World of Goo", "anemone"),
            New EpicGamesBBDDEntrada("World War Z", "world-war-z")
        }

        Return lista
    End Function

End Module

Public Class EpicGamesBBDDEntrada

    Public Titulo As String
    Public ID As String

    Public Sub New(ByVal titulo As String, ByVal id As String)
        Me.Titulo = titulo
        Me.ID = id
    End Sub

End Class
