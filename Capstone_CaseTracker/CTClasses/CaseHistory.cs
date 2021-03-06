﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTClasses
{
    public class CaseHistory
    {
        //private  DateTime.now() _dateTime;  field to be added when we test the DB, will be PK in table
        //private string _userID;                field to be added when we test the DB, will be PK in table
        //note composite primary key is required to uniquely id each row in table.  Request help as to how this should
        //translate into properties/fields in C# class
        //private string _indivID;               field to be added when we test DB
        private string _dateCaseCreated;  //enter date the case was created
        private string _telephoneCall;  //is the note being entered as the result of a call? yes/no
        private string _visit;          //is the note being entered as the result of a visit? yes/no
        private string _mentalHealthNote; //limit I put into MySQL DB table is 500 characters
        private string _medicalHealthNote;                //"
        private string _substanceConcernNote;             //"
        private string _nutritionNote;
        private string _hygeineNote;
        private string _clothingNote;
        private string _houseEnvironmentNote;
        private string _weaponsNote;
        private string _otherNote; //something outside of our analyzable categories
        private string _dateCaseClosed;  //enter the date the case was closed

        public CaseHistory()   //no arg constructor used to create object with no parameters
        { }

        //constructor with parameters
        public CaseHistory( // DateTime.now() dateTime, string userID, string indivID,
            string dateCaseCreated, string telephoneCall, string visit, string mentalHealthNote, string medicalHealthNote,
            string substanceConcernNote, string nutritionNote, string hygeineNote, string clothingNote, string houseEnvironmentNote,
            string weaponsNote, string otherNote, string dateCaseClosed)
        {
            //dateTime = _dateTime;
            //userID = _userID;
            //indivID = _indivID;
            dateCaseCreated = _dateCaseCreated;
            telephoneCall = _telephoneCall;
            visit = _visit;
            mentalHealthNote = _mentalHealthNote;
            medicalHealthNote = _medicalHealthNote;
            substanceConcernNote = _substanceConcernNote;
            nutritionNote = _nutritionNote;
            hygeineNote = _hygeineNote;
            clothingNote = _clothingNote;
            houseEnvironmentNote = _houseEnvironmentNote;
            weaponsNote = _weaponsNote;
            otherNote = _otherNote;
            dateCaseClosed = _dateCaseClosed;
        }

        //setters and getters, int ID's and dateTime have no setters, they will be generated in the DB

        // public dateTime.now()  dateTime  //HELP is this how to do this?    //these three getters will be used when DB is engaged
        //{
        //    get { return _dateTime;}
        //}
        //public string userID
        //{
        //    get { return _userID; }            
        //}
        //public string indivID
        //{
        //    get { return _indivID; }            
        //}
        public string dateCaseCreated
        {
            get { return _dateCaseCreated; }
            set { _dateCaseCreated = value; }
        }
        public string telephoneCall
        {
            get { return _telephoneCall; }
            set { _telephoneCall = value; }
        }
        public string visit
        {
            get { return _visit; }
            set { _visit = value; }
        }
        public string mentalHealthNote
        {
            get { return _mentalHealthNote; }
            set { _mentalHealthNote = value; }
        }
        public string medicalHealthNote
        {
            get { return _medicalHealthNote; }
            set { _medicalHealthNote = value; }
        }
        public string substanceConcernNote
        {
            get { return _substanceConcernNote; }
            set { _substanceConcernNote = value; }
        }
        public string nutritionNote
        {
            get { return _nutritionNote; }
            set { _nutritionNote = value; }
        }
        public string hygeineNote
        {
            get { return _hygeineNote; }
            set { _hygeineNote = value; }
        }
        public string clothingNote
        {
            get { return _clothingNote; }
            set { _clothingNote = value; }
        }
        public string houseEnvironmentNote
        {
            get { return _houseEnvironmentNote; }
            set { _houseEnvironmentNote = value; }
        }
        public string weaponsNote
        {
            get { return _weaponsNote; }
            set { _weaponsNote = value; }
        }
        public string otherNote
        {
            get { return _otherNote; }
            set { _otherNote = value; }
        }
        public string dateCaseClosed
        {
            get { return _dateCaseClosed; }
            set { _dateCaseClosed = value; }
        }
        public void setDefaults()
        {
            this.dateCaseCreated = "November 15, 2017";
            this.telephoneCall = "yes/true";
            this.visit = "yes/true";
            this.mentalHealthNote = "child has bi-polar disorder";
            this.medicalHealthNote = " child is in 50% for height and 25% for weight.";
            this.substanceConcernNote = "many empty hard liquer bottles strewn around.";
            this.nutritionNote = "child is thin and hungry, no food present.";
            this.hygeineNote = "child appears unbathed and noticably smelly";
            this.clothingNote = "child shabbily clothed.";
            this.houseEnvironmentNote = "house filthy, garbage overflowing, extremely cold.";
            this.weaponsNote = "no weapons in view.";
            this.otherNote = "child continuously crying, caretaker ignoring cries.";

        }
    }
}
