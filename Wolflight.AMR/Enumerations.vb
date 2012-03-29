Public Module Enumerations

    Public Enum Buff As Byte
        None = 0
        Power
        Stats = 2
        Endurance = 4
        Crit = 8
    End Enum

    Public Enum Stance
        None = 0
        DarkCharge
        LightningCharge
        SurgingCharge
        Soresu
        ShiiCho
        Shien
        Ataru
        Juyo
        Combustible
        Ion
        HighEnergy
        CombatSupport
        HighVelocity
    End Enum

    Public Enum CharacterSlot As Byte
        None = 0
        MainHand
        OffHand
        Belt
        Chest
        Ears
        Feet
        Glove
        Helm
        Implant1
        Leg
        Wrist
        Relic1
        Implant2
        Relic2

        Part1
        Part2
        SensorUnit
        Core1
        Core2
        Motor1
        Motor2
        Customization
    End Enum

    Public Enum ModSlot As Byte
        None = 0
        Armoring
        Augment
        Barrel
        ColorCrystal
        Enhancement
        Hilt
        [Mod]
    End Enum

    Public Enum Stat As Byte
        None = 0
        Strength
        Endurance
        Crit
        Power
        Defense
        Accuracy
        Alacrity
        Surge
        Shielding
        Presence
        Will
        Cunning
        Aim
        Absorb
        Expertise
        Armor
        MinDamage
        MaxDamage
        TechPower
        ForcePower
    End Enum

    Public Enum WeaponType As Byte
        None = 0
        LightSaber
        Pistol
        PoleSaber
        BlasterRifle
        VibroKnife
        VibroSword
        TrainingSaber
        ScatterGun
        AssaultCannon
        SniperRifle
        ElectroStaff
        TechBlade
        TechStaff
    End Enum

    Public Enum ArmorType As Byte
        None = 0
        Light
        Medium
        Heavy
    End Enum

    Public Enum ShieldType As Byte
        None = 0
        Focus
        Generator
        ForceShield
        TechShield
    End Enum

    Public Enum SwtorRegion
        Unknown = 0
        US
        EU
        Asia
    End Enum

    Public Enum Faction
        Unknown = 0
        Empire
        Republic
    End Enum

    Public Enum AdvancedClass As Byte
        Unknown = 0
        Guardian
        Sentinel
        Commando
        Vanguard
        Sage
        Shadow
        Gunslinger
        Scoundrel
        Juggernaut
        Marauder
        Mercenary
        Powertech
        Assassin
        Sorcerer
        Operative
        Sniper
    End Enum

    Public Enum Gender As Byte
        Unknown = 0
        Female
        Male
    End Enum

    Public Enum Race
        Unknown = 0
        Chiss
        Cyborg
        Human
        Miraluka
        Mirialan
        Rattataki
        SithPureblood
        Twilek
        Zabrak
    End Enum

    Public Enum Alignment
        Neutral = 0
        Dark1 = -1
        Dark2 = -2
        Dark3 = -3
        Dark4 = -4
        Dark5 = -5
        Light1 = 1
        Light2 = 2
        Light3 = 3
        Light4 = 4
        Light5 = 5
    End Enum

    Public Enum SocialLevel
        None = 0
        Social1
        Social2
        Social3
        Social4
        Social5
        Social6
        Social7
        Social8
        Social9
        Social10
    End Enum

    Public Enum CrewSkill
        None = 0
        Archaeology
        Bioanalysis
        Scavenging
        Slicing
        Armormech
        Armstech
        Artifice
        Biochem
        Cybertech
        Synthweaving
        Diplomacy
        Investigation
        TreasureHunting
        UnderworldTrading
    End Enum

    Public Enum Quality As Byte
        Cheap = 0
        Standard
        Premium
        Prototype
        Custom
        Artifact
        Legendary
        Legacy
    End Enum

    Public Enum ItemSlot As Byte
        None = 0
        Belt
        Ear
        Helm
        Chest
        PrimaryRanged
        SecondaryRanged
        EitherRanged
        CustomRanged
        Foot
        Hands
        Wrist
        Legs
        Implant
        Shield
        MainHand
        OffHand
        EitherHand
        CustomMelee
        Relic

        DroidParts
        DroidSensor
        DroidMotor
        DroidCore

        Customization
    End Enum

End Module
