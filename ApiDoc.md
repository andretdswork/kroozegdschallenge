#CalculateInstallmentsController

#ActionResult<int> Get(decimal fullPrice)
- Responável por trazer o máximo de parcelas

Parâmetros de entrada — fullPrice 
	- Valor base para o cálculo das parcelas

Endpoints
	# /api/CalculateInstallments/Installments/10000
	# /api/CalculateInstallments/Installments/1
	# /api/CalculateInstallments/Installments/0

============================================================================================================
#CruiseController

#Get(int cruiseRequestDTO)
	- retorna uma list de Cruises

	Endpoints
		# /api/Cruise/1
		# /api/Cruise/2
		# /api/Cruise/3
		EndPoints não aceitos
		# /api/Cruise/4 com o final maior que

#Get(decimal firstPassenger, decimal secondPassenger)
	- determina se poderá have um desconto com base nesses valores e retorna um bool 

	Endpoints
		# /api/Cruise/IsThereDiscount/1/2
		# /api/Cruise/IsThereDiscount/2/3
		# /api/Cruise/IsThereDiscount/3/4
	
#Get(decimal cabinValue, decimal portCharge, decimal totalValue)
	- retorna um inteiro que representa outros tipos de taxas

	Endpoints
		# /api/Cruise/OtherTaxes/1/2/3
		# /api/Cruise/OtherTaxes/2/3/4
		# /api/Cruise/OtherTaxes/3/4/4

============================================================================================================
#MoviesController

#Get()
	- retorna um objeto json que representa com dados referente a um filme

	Endpoints
		# /api/Movies/allMovies/

#GetDirector()
	- retorna um string que representa o nome do diretor

	Endpoints
		# /api/Movies/director/

============================================================================================================
#XmlCruiseController

#Get()
	- retorna uma estrutura simplificada do xml Cruises.xml

	Endpoints
		# /api/XmlCruise/CruiseXml/
