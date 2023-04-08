using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Zusammen.Models
{
    public enum SchoolYear
    {
        Freshman,
        Sophemore,
        Junior,
        Senior,
        [Display(Name = "Super Senior")]
        superSenior,
        [Display(Name = "Graduate Student")]
        gradStudent
    }

    public enum SchoolHousing
    {
        [Display(Name = "Academic and Residential Complex")]
        arc,
        [Display(Name = "Commons North")]
        cn,
        [Display(Name = "Commons West")]
        cw,
        [Display(Name = "Courtyard")]
        cty,
        [Display(Name = "James Stukel Towers")]
        jst,
        [Display(Name = "Marie Robinson Hall")]
        mrh,
        [Display(Name = "Single Student Residence")]
        ssr,
        [Display(Name = "Thomas Bekham Hall")]
        tbh,
        [Display(Name = "Commuter")]
        commuter
    }

    public enum Major
    {
        Accounting,
        Acting,
        Anthropology,
        [Display(Name = "Applied Psychology")]
        AppliedPsychology,
        [Display(Name = "Architectural Studies")]
        ArchitecturalStudies,
        Architecure,
        Art,
        [Display(Name = "Art History")]
        ArtHistory,
        Biochemistry,
        [Display(Name = "Biological Sciences")]
        BiologicalSciences,
        [Display(Name = "Biomedical Engineering")]
        BiomedicalEngineering,
        [Display(Name = "Biopharmaceutical Sciences")]
        BiopharmaceuticalSciences,
        [Display(Name = "Black Studies")]
        BlackStudies,
        [Display(Name = "Chemical Engineering")]
        ChemicalEngineering,
        Chemistry,
        [Display(Name = "Civil Engineering")]
        CivilEngineering,
        [Display(Name = "Classical Studies")]
        ClassicalStudies,
        Communications,
        [Display(Name = "Computer Engineering")]
        ComputerEngineering,
        [Display(Name = "Computer Science")]
        ComputerScience,
        [Display(Name = "Computer Science and Design")]
        ComputerScienceAndDesign,
        [Display(Name = "Computer Science and Linguistics")]
        ComputerScienceAndLinguistics,
        [Display(Name = "Criminology Law and Justice")]
        CriminologyLawAndJustice,
        [Display(Name = "Desgin Studies")]
        DesginStudies,
        [Display(Name = "Disability and Human Development")]
        DisabilityAndHumanDevelopment,
        [Display(Name = "Earth and Enviromental Sciences")]
        EarthAndEnviromentalSciences,
        Economics,
        [Display(Name = "Electrical Engineering")]
        ElectricalEngineering,
        [Display(Name = "Engineering Managment")]
        EngineeringManagment,
        [Display(Name = "Engineering Physics")]
        EngineeringPhysics,
        English,
        Entrepreneurship,
        [Display(Name = "Enviornmental Engineering")]
        EnviornmentalEngineering,
        Finance,
        [Display(Name = "French and Francophone Studies")]
        FrenchAndFrancophoneStudies,
        [Display(Name = "Gender and Women's Studies")]
        GenderAndWomensStudies,
        [Display(Name = "Germanic Studies")]
        GermanicStudies,
        [Display(Name = "Global Asian Studies")]
        GlobalAsianStudies,
        [Display(Name = "Graphic Design")]
        GraphicDesign,
        [Display(Name = "Health Ifnormation Management")]
        HealthIfnormationManagement,
        History,
        [Display(Name = "Human Development and Learning")]
        HumanDevelopmentAndLearning,
        [Display(Name = "Human Resource Managment")]
        HumanResourceManagment,
        [Display(Name = "Industrial Design")]
        IndustrialDesign,
        [Display(Name = "Industrial Engineering")]
        IndustrialEngineering,
        [Display(Name = "Information and Decision Sciences")]
        InformationAndDecisionSciences,
        [Display(Name = "Integrated Health Studies")]
        IntegratedHealthStudies,
        [Display(Name = "Interdisciplinary Education in the Arts")]
        InterdisciplinaryEducationInTheArts,
        Italian,
        [Display(Name = "Jazz Studies")]
        JazzStudies,
        Kinesiology,
        [Display(Name = "Latin American and Latino Studies")]
        LatinAmericanAndLatinoStudies,
        [Display(Name = "Liberal Studies")]
        LiberalStudies,
        Management,
        Marketing,
        Mathematics,
        [Display(Name = "Mathematics and Computer Science")]
        MathematicsAndComputerScience,
        [Display(Name = "Mechanical Engineering")]
        MechanicalEngineering,
        Music,
        [Display(Name = "Music Business")]
        MusicBusiness,
        Neuroscience,
        Nursing,
        Nutrition,
        Performance,
        Pharmacy,
        Philosophy,
        Physics,
        [Display(Name = "Polish Russian and Central and Eastern European Studies")]
        PolishRussianAndCentralAndEasternEuropeanStudies,
        [Display(Name = "Political Science")]
        PoliticalScience,
        Psychology,
        [Display(Name = "Public Health")]
        PublicHealth,
        [Display(Name = "Public Policy")]
        PublicPolicy,
        [Display(Name = "Real Estate")]
        RealEstate,
        [Display(Name = "Rehabilitation Sciences")]
        RehabilitationSciences,
        Sociology,
        Spanish,
        Statistics,
        [Display(Name = "Teaching of English")]
        TeachingOfEnglish,
        [Display(Name = "Teaching of French")]
        TeachingOfFrench,
        [Display(Name = "Teaching of German")]
        TeachingOfGerman,
        [Display(Name = "Teaching of History")]
        TeachingOfHistory,
        [Display(Name = "Teaching of Mathematics")]
        TeachingOfMathematics,
        [Display(Name = "Teaching of Physics")]
        TeachingOfPhysics,
        [Display(Name = "Teaching of Spanish")]
        TeachingOfSpanish,
        [Display(Name = "Theatre and Performance")]
        TheatreAndPerformance,
        [Display(Name = "Urban Education")]
        UrbanEducation,
        [Display(Name = "Urban Studies")]
        UrbanStudies
    }

    public enum Hobbies
    {
        Writing,
        Reading,
        [Display(Name = "Watching Movies/TV Shows")]
        moviesTVShows,
        [Display(Name = "Video Games")]
        videoGames,
        Sports,
        Dancing,
        Hiking,
        Cooking,
        Photography,
        [Display(Name = "Painting/Drawing")]
        PaintingDrawing,
        Yoga,
        Meditation,
        [Display(Name = "Running/Jogging")]
        Running,
        Swimming,
        Biking,
        Skateboarding,
        [Display(Name = "Playing Musical")]
        PlayingMusical,
        Singing,
        Acting,
        Magic,
        [Display(Name = "Martial Arts")]
        MartialArts,
        [Display(Name = "Weightlifting/Bodybuilding")]
        WeightliftingBodybuilding,
        [Display(Name = "Rock Climabing")]
        RockClimbing,
        Gardening,
        Fishing,
        [Display(Name = "Collecting (e.g. stamps, coins, rocks, etc.)")]
        Collecting,
        DIY,
        Woodworking,
        [Display(Name = "Knitting/Crocheting")]
        KnittingCrocheting,
        Sewing,
        Volunteering,
        Tutoring,
        Mentoring,
        Debating,
        [Display(Name = "Model UN")]
        ModelUN
    }

    public enum Gender
    {
        [Display(Name = "Male")]
        male,
        [Display(Name = "Female")]
        female,
        [Display(Name = "Non Binary")]
        non_binary,
        [Display(Name = "Prefer not to Say")]
        not_say

    }
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }
        public SchoolYear schoolyear { get; set; }
        public SchoolHousing schoolhousing { get; set; }
        public Major major { get; set; }

        public String name { get; set; }

        public Gender gender { get; set; }

        [NotMapped]
        public List<Hobbies>? hobbies { get; set; } = new List<Hobbies>();

    }
            

}

