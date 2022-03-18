public class RiskCalculationRepository : Repository<RiskCalculation> ,IRiskCalculationRepository
{
 private CovidContext _context;
          public RiskCalculationRepository(CovidContext context) : base(context)
        {
            _context = context;
        }
  
    
}