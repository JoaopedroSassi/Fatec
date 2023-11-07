package AreaTriangulo;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

/**
 * Servlet implementation class Triangulo
 */
public class Triangulo extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Triangulo() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		PrintWriter saida = response.getWriter();
		
		Double base = Double.parseDouble(request.getParameter("base"));
		Double altura = Double.parseDouble(request.getParameter("altura"));
		
		Double area = (base * altura) / 2; 
		
		saida.println(
				"<html lang=\"pt=br\">"
				+ "<meta charset=\"UTF-8\">"
				+ "<body>"
				+ "<h1>A área do triângulo é igual a "+ area +" unidades de medida.</h1>"
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
