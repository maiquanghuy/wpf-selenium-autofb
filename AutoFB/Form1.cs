using AutoFB.Action;
using AutoFB.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFB
{
    public partial class Form1 : Form
    {
        FbAction action = null;
        public Form1()
        {
            InitializeComponent();

            //register event for background worker
            myBackgroundWorker.DoWork += new DoWorkEventHandler(myBackgroundWorker_DoWork);
            myBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(myBackgroundWorker_ProgressChanged);
            myBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myBackgroundWorker_RunWorkerCompleted);

            //set report progress true for background worker
            myBackgroundWorker.WorkerReportsProgress = true;            

            //disabled textbox and numeric updown            
            txtContentPostStatus.Enabled = false;
            txtLinkLikePost.Enabled = false;
            txtCommentContent.Enabled = false;
            txtLinkComment.Enabled = false;

            //set text default for textbox
            txtLinkLikePost.Text = "https://www.facebook.com/chen.edison.313/posts/458321494568558"
                                     + "\n" + "https://www.facebook.com/chen.edison.313/posts/632408180493221";

            txtLinkComment.Text = "https://www.facebook.com/chen.edison.313/posts/458321494568558"
                                     + "\n" + "https://www.facebook.com/chen.edison.313/posts/632408180493221";
        }

        /// <summary>
        /// Run auto facebook action
        /// </summary>
        /// <param name="e"></param>
        public void RunFbAction(DoWorkEventArgs e)
        {
            //init FbAction
            action = FbAction.GetInstance();
            //init LoginModel
            LoginModel login = new LoginModel(action, txtUser.Text, txtPass.Text);
            //do auto login function
            login.DoProcess();
            //get param from DoWorkEventArgs e            
            Hashtable _arguments = (Hashtable)e.Argument;
            //check LikePost function 
            if (ChkLikePost.Checked)
            {
                //if param has data 
                if(_arguments.Count > 0)
                {
                    //get urllist for LikePost Function
                    string[] _urlList = _arguments["LikePost"] as string [];
                    //do like post function
                    action.LikePost(_urlList);
                }                
            }

            //check LikePost function 
            if (ChkPostStatus.Checked)
            {
                //if param has data 
                if (_arguments.Count > 0)
                {
                    //get urllist for PostStatus Function
                    string[] _contentList = _arguments["PostStatus"] as string[];
                    //do post status function
                    action.PostStatus(_contentList);
                }
            }

            //check Comment function 
            if (ChkComment.Checked)
            {
                //if param has data 
                if (_arguments.Count > 0)
                {
                    //get urllist for LikePost Function
                    string[] _urlList = _arguments["LinkComment"] as string[];
                    //get content comment
                    string _contentComment = _arguments["CommentContent"] as string;
                    //do like post function
                    action.PostComment(_urlList,_contentComment);
                }
            }

            //close driver when done
            //action.Close();
        }
        /// <summary>
        /// start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //disabled start button
            BtnStart.Enabled = false;
            //create list string[] for arguments            
            Hashtable arguments = new Hashtable();
            //check LikePost function
            if (ChkLikePost.Checked)
            {
                //split text in txtLinkLikePost by new line
                string[] _urlList = txtLinkLikePost.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                //add link need to likepost to arguments
                arguments.Add("LikePost",_urlList);
            }
            if (ChkPostStatus.Checked)
            {
                //split text in txtContentPostStatus by new line
                string[] _statusList = txtContentPostStatus.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                //add link need to likepost to arguments
                arguments.Add("PostStatus", _statusList);                
            }
            if (ChkComment.Checked)
            {
                //split text in txtLinkComment by new line
                string[] _urlList = txtLinkComment.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                //add link need to likepost to arguments
                arguments.Add("LinkComment", _urlList);
            }
            arguments.Add("CommentContent", txtCommentContent.Text);

            //call dowork function
            myBackgroundWorker.RunWorkerAsync(arguments);
        }

        /// <summary>
        /// Checkbox LikePost  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkLikePost_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLikePost.Checked)
            {
                txtLinkLikePost.Enabled = true;                
            }
            else
            {
                txtLinkLikePost.Enabled = false;
            }
        }

        /// <summary>
        /// Checkbox PostStatus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkPostStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPostStatus.Checked)
            {
                txtContentPostStatus.Enabled = true;
            }
            else
            {
                txtContentPostStatus.Enabled = false;
            }
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //check action null
            if(action != null)
            {
                //close action
                action.Close();
            }            
            Application.Exit();
        }

        /// <summary>
        /// Do work event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            myBackgroundWorker.ReportProgress(1);
            RunFbAction(e);
            myBackgroundWorker.ReportProgress(100);
        }

        /// <summary>
        /// Progress change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage < 100)
            {
                lblStatus.Text = "Processing...";
            }            
        }

        /// <summary>
        /// Run worker completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Done.";
            MessageBox.Show("Success!");
            BtnStart.Enabled = true;
        }

        /// <summary>
        /// Checkbox comment event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkComment_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkComment.Checked)
            {
                txtCommentContent.Enabled = true;
                txtLinkComment.Enabled = true;
            }
            else
            {
                txtCommentContent.Enabled = false;
                txtLinkComment.Enabled = false;
            }
        }
    }
}
