using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Task
{
    public class DataContext : DbContext
    {
        /*
        protected void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=BD.db");
            */

        public DbSet<DataEmployeeEffectiveness> employeeEffectivenesses { get; set; }
        public DbSet<DataEmployeeEffectivenessByManager> employeeEffectivenessByManager { get; set; }
        public DbSet<DataLevelCompetenceKnowledgeDevelopment>  levelcompetenceknowledgedevelopment{ get; set; }
        public DbSet<DataFinalEffectivenesDevelopment> finaleffectivenesdevelopment { get; set; }
        public DbSet<DataIndividualEmployeeTasks>  individualemployeetasks{ get; set; }
        public DbSet<DataIndividualEmployeeDevelopment>  individualEmployeeDevelopment{ get; set; }
        
        public DbSet<DataFinalFormQuestionnaire>  finalformquestionnaire{ get; set; }


    }

    public class DataEmployeeEffectiveness
    {
        [Key] public int EmployeeEffectivenessID { get; set; } 
        [Required]
        public string Zadacha { get; set; } 
        public string Achivement { get; set; }
        public string WhatWantImprove { get; set; }
        public string AdditionalWork { get; set; }
        
        public List<DataFinalFormQuestionnaire> DataFinalFormQuestionnaire { get; set; }
 }
    public class DataEmployeeEffectivenessByManager
    {
        [Key] public int EmployeeEffectivenessByManagerID { get; set; } 
        [Required]
        public string Workload { get; set; } 
        public string AdditinalProjects { get; set; }
        public string QualityExecution { get; set; }
        public string TimelineExecution { get; set; }
        public string EvaluenceEffectivenes { get; set; }
        
        public List<DataFinalFormQuestionnaire> DataFinalFormQuestionnaire { get; set; }
        }
    
    public class DataLevelCompetenceKnowledgeDevelopment
    {
        [Key] public int LevelCompetenceKnowledgeDevelopmentID { get; set; } 
        [Required]
        public string EvaluenceManager { get; set; } 
        public string EvaluenceEmployee { get; set; }
        public string AverageValueKnowledge { get; set; }
        
        public string EvaluenceCompetence { get; set; }
        public string AverageValueDevelopment { get; set; }

        public int SumValueKnowledge { get; set; }
        public int FinalEvaluenceDevelopment { get; set; }
        
        public List<DataFinalFormQuestionnaire> DataFinalFormQuestionnaire { get; set; }
    }
    
    public class DataFinalEffectivenesDevelopment
    {
        [Key] public int FinalEffectivenesDevelopmentID { get; set; } 
        [Required]
        public string EvaluenceEffectivenes { get; set; } 
        public string EvaluenceComptenece { get; set; }
        public string FinalEvaluenceEffectivenes { get; set; }
        public string ProposalsEstablishmentProfessionalStatus { get; set; }
        
        public List<DataFinalFormQuestionnaire> DataFinalFormQuestionnaire { get; set; }
    }
    public class DataIndividualEmployeeTasks
    {
        [Key] public int IndividualEmployeeTasksID { get; set; } 
        [Required]
        public string Zadacha { get; set; } 
        public string KeyResult { get; set; }
        public string TimelineExecution { get; set; }
        public string Comment { get; set; }
        
        public List<DataFinalFormQuestionnaire> DataFinalFormQuestionnaire { get; set; }
    }
    public class DataIndividualEmployeeDevelopment
    {
        [Key]
        public int IndividualEmployeeDevelopmentID { get; set; }
 
        [Required]
        public string DevelopmentObjective { get; set; } 
        public string MethodDevelopment { get; set; }
        public string Responsible { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        
        public List<DataFinalFormQuestionnaire> DataFinalFormQuestionnaire { get; set; }
    }
    
    public class DataFinalFormQuestionnaire
    {
        [Key] public int FinalFormQuestionnaireID { get; set; } 
        
        
        
        [Required]
        public int IndividualEmployeeDevelopmentID { get; set; }
        public int IndividualEmployeeTasksID { get; set; } 
        public int FinalEffectivenesDevelopmentID { get; set; } 
        public int LevelCompetenceKnowledgeDevelopmentID { get; set; } 
        public int EmployeeEffectivenessByManagerID { get; set; } 
        public int EmployeeEffectivenessID { get; set; }
        
        public DataIndividualEmployeeDevelopment DataIndividualEmployeeDevelopment { get; set; }
        public DataIndividualEmployeeTasks DataIndividualEmployeeTasks { get; set; }
        public DataFinalEffectivenesDevelopment DataFinalEffectivenesDevelopment { get; set; }
        public DataLevelCompetenceKnowledgeDevelopment DataLevelCompetenceKnowledgeDevelopment { get; set; }
        public DataEmployeeEffectivenessByManager DataEmployeeEffectivenessByManager { get; set; }
        public DataEmployeeEffectiveness DataEmployeeEffectiveness { get; set; }

    }
}
