package Servelete;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

/**
 * Servlet implementation class CalcHipotenusa
 */
public class CalcHipotenusa extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CalcHipotenusa() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		PrintWriter saida = response.getWriter();
		
		Double cateto1 = Double.parseDouble(request.getParameter("cateto1"));
		Double cateto2 = Double.parseDouble(request.getParameter("cateto2"));
		
		Double hipotenusa = (cateto1 * cateto1) + (cateto2 * cateto2);
		
		
		saida.println(
				"<html lang=\"pt=br\">"
				+ "<meta charset=\"UTF-8\">"
				+ "<body>"
				+ "<h1>Hipotenusa: "+ hipotenusa +"</h1>"
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
