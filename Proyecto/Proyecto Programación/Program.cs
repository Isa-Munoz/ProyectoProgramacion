public class Usuarios 
{
    public int id_usuario;
    public string? nom_usuario = null;
    public string? apellido_usuario = null;
    public string? correo_usuario = null;
    public string? telefono_usuario = null;
    public Roles? tipo;

    public Usuarios(int id_usuario, string? nom_usuario, string? apellido_usuario, string? correo_usuario, string? telefono_usuario, Roles? tipo)
    {
        this.id_usuario = id_usuario;
        this.nom_usuario = nom_usuario;
        this.apellido_usuario = apellido_usuario;
        this.correo_usuario = correo_usuario;
        this.telefono_usuario = telefono_usuario;
        this.tipo = tipo;
    }
}

public class Roles
{
    public int id_roles;
    public string? nom_roles = null;

    public Roles ()
    {
    }

    public Roles (int id_roles, string? nom_roles) 
    {
        this.id_roles = id_roles;
        this.nom_roles = nom_roles;
    }
}

public class Prestamos
{
    public int id_prestamo;
    public Libros? id_libro = null;
    public DateTime fecha_prestamo;
    public DateTime fecha_aprox_devolucion;
    public Usuarios? id_usuario = null;

    public Prestamos(int id_prestamo, Libros? id_libro, DateTime fecha_prestamo, DateTime fecha_aprox_devolucion, Usuarios? id_usuario)
    {
        this.id_prestamo = id_prestamo;
        this.id_libro = id_libro;
        this.fecha_prestamo = fecha_prestamo;
        this.fecha_aprox_devolucion = fecha_aprox_devolucion;
        this.id_usuario = id_usuario;
    }

}

public class Libros
{
    public int id_libro;
    public string? titulo = null;
    public Autores? id_autor;
    public Editoriales? id_editorial;
    public string? estado;

    public Libros(int id_libro, string? titulo, Autores? id_autor, Editoriales? id_editorial, string? estado)
    {
        this.id_libro = id_libro;
        this.titulo = titulo;
        this.id_autor = id_autor;
        this.id_editorial = id_editorial;
        this.estado = estado;
    }
}

public class Autores
{
    public int id_autor;
    public string? nom_autor;
    public string? apellido_autor;
    public Libros? id_libro;

    public Autores(int id_autor, string? nom_autor, string? apellido_autor,Libros? id_libro)
    {
        this.id_autor = id_autor;
        this.nom_autor = nom_autor;
        this.apellido_autor = apellido_autor;
        this.id_libro = id_libro;
    }
}

public class Multas
{
    public int id_multas;
    public double valor_multa;
    public Usuarios? id_usuario;
    public string? descripcion = null;
    public DateTime fecha_multa;

    public Multas(int id_multas, double valor_multa, Usuarios? id_usuario, string? descripcion, DateTime fecha_multa)
    {
        this.id_multas = id_multas;
        this.valor_multa = valor_multa;
        this.id_usuario = id_usuario;
        this.descripcion = descripcion;
        this.fecha_multa = fecha_multa;
    }
}

public class Devoluciones
{
    public int id_devoluciones;
    public Libros? id_libro;
    public DateTime fecha_devolucion;
    public Usuarios? id_usuario;

    public Devoluciones(int id_devoluciones, Libros? id_libro, DateTime fecha_devolucion, Usuarios? id_usuario)
    {
        this.id_devoluciones = id_devoluciones;
        this.id_libro = id_libro;
        this. fecha_devolucion = fecha_devolucion;
        this.id_usuario = id_usuario;
    }
}

public class Editoriales
{
    public int id_editorial;
    public string? nom_editorial = null;
    public Libros? id_libro;

    public Editoriales(int id_editorial, string? nom_editorial, Libros? id_libro)
    {
        this.id_editorial = id_editorial;
        this.nom_editorial = nom_editorial;
        this.id_libro = id_libro;
    }
}

