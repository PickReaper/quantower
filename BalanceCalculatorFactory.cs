namespace TradingPlatform.BusinessLayer;

public delegate IBalanceCalculator BalanceCalculatorFactory(Symbol symbol, Account account);
