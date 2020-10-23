using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Business.Entities;

namespace Data.Database
{
    class PersonaAdapter:Adapter
    {
        public Persona GetOne(int ID)
        {
            Persona persona = new Persona();
            try
            {
                this.OpenConnection();

                SqlCommand cmdPersona = new SqlCommand("Select * from personas where id_persona = @id", sqlConn);
                cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersona = cmdPersona.ExecuteReader();

                if (drPersona.Read())
                {
                    persona.ID = (int)drPersona["id_persona"];
                    persona.Nombre = (string)drPersona["nombre"];
                    persona.Apellido = (string)drPersona["apellido"];
                    persona.Direccion = (string)drPersona["hs_totales"];
                    persona.Email = (string)drPersona["email"];
                    persona.Telefono = (string)drPersona["telefono"];
                    persona.FechaNacimiento = (DateTime)drPersona["fecha_nac"];
                    persona.Legajo = (int)drPersona["legajo"];
                    persona.TipoPersona = (Persona.TiposPersona)(int)drPersona["tipo_persona"];
                    persona.IDPlan = (int)drPersona["id_plan"];
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
               new Exception("Error al recuperar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally { this.CloseConnection(); }
            return persona;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete materias where id_persona=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Persona persona)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET id_plan=@plan,tipo_persona=@t_persona,legajo=@legajo,telefono=@telefono,email=@email,direccion=@direccion,apellido=@apellido,nombre=@nombre,fecha_nac=@fecha_nac WHERE id_persona=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@t_persona", SqlDbType.Int).Value = persona.TipoPersona;
                cmdSave.Parameters.Add("@plan", SqlDbType.Int).Value = persona.IDPlan;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar los datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Materia materia)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("INSERT into personas (id_plan,tipo_persona,legajo,telefono,email,direccion,apellido,nombre,fecha_nac,id_pe) VALUES(@desc,@hs_sem,@hs_totales,@id_plan) Select @@identity", sqlConn);

                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_sem", SqlDbType.Int).Value = materia.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                materia.ID = decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
     
        //public void Save(Materia materia)
        //{
        //    if (materia.State == BusinessEntity.States.New)
        //    {
        //        this.Insert(materia);
        //    }
        //    else if (materia.State == BusinessEntity.States.Deleted)
        //    {
        //        this.Delete(materia.ID);
        //    }
        //    else if (materia.State == BusinessEntity.States.Modified)
        //    {
        //        this.Update(materia);
        //    }
        //    materia.State = BusinessEntity.States.Unmodified;
        //}
    }
}
