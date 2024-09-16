namespace Model.Entidades
{
    public class CursoDisciplinaEntidade
    {
        public int Id { get; set; } = 0;
        public int DisciplinaId { get; set; }
        public int CursoId { get; set; }
        public string Periodo { get; set; }
        //SELECT
        //CD.Id,
        //C.Nome,
        //C.Id,
        //CD.Periodo
        //FROM CURSO_DISCIPLINA AS CD
        //INNER JOIN CURSOS AS C
        //ON C.Id = CD.Curso_Id
        //INNER JOIN DISCIPLINAS AS D
        //ON
        //D.Id = CD.Disciplina_Id;
    }
}
