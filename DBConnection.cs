using System;

public class DBConnection
{
    //数据库相关配置信息
    private string DBServer = "localhost";
    private string DBname = "test_schema";
    private string DBuserName = "root";
    private string DBpassword = "ca.0123";
   
/*
    private string tableName = "usertable";
    private string userNameCol = "userid";
    private string passwordCol = "userpwd";*/
    
    //数据库连接状态
    private bool isConnected = false;

    //数据库连接命令
    private MySqlConnection conn;

    public DBConnection()
	{
        //初始化变量
        this.isConnected = false;
	}

    /// <summary>
    /// 数据库连接方法
    /// </summary>
    public void Open()
    {
        try
        {
            string connstring = "Server=" + DBServer + ";Database =" + DBname + ";Uid=" + DBuserName + ";Pwd=" + DBpassword + ";";

            this.conn = new MySqlConnection(connstring);
            this.conn.Open();

            this.isConnected = true;
        }
        catch(Exception)
        {
            MessageBox.show("数据库连接失败！", "错误");
        }
    }

    /// <summary>
    /// 数据库连接关闭方法
    /// </summary>
    public void Close()
    {
        if (! this.isConnected)
        {
            MessageBox.show("数据库尚未连接！", "错误");
            return;
        }
        else
        {
            this.conn.Close();
            this.isConnected = false;
        }
    }

    /// <summary>
    /// 检查当前是否连接
    /// </summary>
    /// <returns></returns>
    public bool isConnectedNow()
    {
        return this.isConnected;
    }

    /// <summary>
    /// 查找数据库是否存在某项
    /// </summary>
    public bool isExisted(string tableName, string colName, string value)
    {
        if (! this.isConnected)
        {
            MessageBox.show("数据库尚未连接！", "错误");
            return false;
        }

        string query = "select count(*) from " + tableName + " where " + ColName + "='" + value + "';";
        cmd = new MySqlCommand(query, conn);

        num = (long)cmd.ExecuteScalar();
        if (num != 0l) return true;
        else return false;
    }


}
