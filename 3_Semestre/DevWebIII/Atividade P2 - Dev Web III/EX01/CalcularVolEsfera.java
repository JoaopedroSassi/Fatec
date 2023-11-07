package ServletEsfera;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.DecimalFormat;

/**
 * Servlet implementation class CalcularVolEsfera
 */
public class CalcularVolEsfera extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CalcularVolEsfera() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		PrintWriter saida = response.getWriter();
		
		Double pi = Math.PI;
		
		Double raio = Double.parseDouble(request.getParameter("raio"));
		
		DecimalFormat df = new DecimalFormat("0.00");
		
		Double volume = (4 * pi * (raio * raio * raio)) / 3;
		
		saida.println(
				"<html lang=\"pt=br\">"
				+ "<meta charset=\"UTF-8\">"
				+ "<body>"
				+ "<h1>Raio da efera é igual a "+ df.format(volume) +" unidades</h1>"
				+ "</body>"
				+ "</html>"				
				);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
