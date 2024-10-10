Empresa ulbre = new Empresa();
Funcionario marcelo = new Funcionario("Marcelo", 21);

Gerente lucas = new Gerente("Lucas", 32, 50);
Estagiario pedro = new Estagiario("Pedro", 19);

ulbre.AdicionarFuncionario(marcelo); 
ulbre.AdicionarFuncionario(lucas);   
ulbre.AdicionarFuncionario(pedro); 
ulbre.ListarFuncionarios();        
