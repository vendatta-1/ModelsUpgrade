using Microsoft.EntityFrameworkCore;

namespace ModelsUpgrade.UpdatedModels.Education.EducationValueObjs
{
    [Owned]
    public record QuestionMasterInfo
    (

        string QuestionDetails,
        string QuestionAnswer,
        int? QuestionValue,
        string Description

    );
}
