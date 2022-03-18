public class RiskCalculation
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int Name { get; set; }
    public bool Fire { get; set; }
    public bool RunnyNose { get; set; }
    public bool BodyPain { get; set; }
    public bool Fatigue { get; set; }
    public bool Cough { get; set; }
    public bool Chronic { get; set; }
    public bool SmellAndTaste { get; set; }
    public virtual IEnumerable <User>? Users { get; set; }

}
