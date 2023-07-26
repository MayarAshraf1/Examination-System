namespace McqExaminationSystem.DataTransferObjectsManagers.ExamDtosManager.ExamDtos
{
    public sealed record ExamDto(
        string ExamName,
        string ExamDescription,
        int ExamId = 0,
        bool IsDeleted = false);
}
