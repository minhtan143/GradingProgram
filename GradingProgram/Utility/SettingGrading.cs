using System.Collections.Generic;

namespace GradingProgram
{
    public enum Comparator { CNumber, CStringCase, CStringIgnoreCase, CArrayNumber, CMultipleLines, CMultipleLinesIgnoreIndex, CCustom };

    class SettingGrading
    {
        public List<string> LanguageGrading { get; set; }

        public bool GradingNoBuilt { get; set; }

        public bool AutomaticCandidateMirroring { get; set; }

        public Comparator Comparator { get; set; }
    }
}
