﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using ServerSide.Reports;

namespace ServerSide.PredefinedReports {
    public static class ReportsFactory {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>() {

            //["RoomHistoryReport"] = () => new RoomHistoryReport(),
            ["ArrivalDepartureStayOverReport"] = () => new ArrivalDepartureStayOverReport(),
            ["GuestLedgerReport"] = () => new GuestLedgerReport(),
            ["GuestOutstandingReport"] = () => new GuestOutstandingReport(),

            ["MonthlyCheckInReport"] = () => new MonthlyCheckInReport(),
            ["DailyRevenuSummaryReport"] = () => new DailyRevenuSummaryReport(),
            ["RoomHistoryReport"] = () => new RoomHistoryReport(),

            ["CurrencyReport"] = () => new CurrencyReport(),
            ["AuditTrailReport"] = () => new AuditTrailReport(),
            ["ReceiptReport"] = () => new ReceiptReport(),

            //["TestReport"] = () => new TestReport(),
            //["EmployeeAgeRangeReport"] = () => new EmployeeAgeRangeReport(),
            //["EmployeeAgeSummaryReport"] = () => new EmployeeAgeSummaryReport(),
            //["EmployeeFamilySummaryReport"] = () => new EmployeeFamilySummaryReport(),
            //["EmployeeFamilyReport"]=() => new EmployeeFamilyReport(),
            //["EmployeeListReport"] = () => new EmployeeListReport(),
            //["EmployeeListSummaryReport"] = () => new EmployeeListSummaryReport(),
            //["FaultEntryFleetHistoryReport"] = () => new FaultEntryFleetHistoryReport(),
            //["FaultEntryPendingReport"] = () => new FaultEntryPendingReport(),
            //["FaultEntrySolvedReport"] = () => new FaultEntrySolvedReport(),
            //["FaultEntrySummaryReport"] = () => new FaultEntrySummaryReport(),
            //["FleetScheduleReport"] = () => new FleetScheduleReport(),
            //["EmployeeDivisionReport"] = () => new EmployeeDivisionReport(),
            //["EmployeeDivisionSummaryReport"] = () => new EmployeeDivisionSummaryReport(),
            //["LeaveDepartmentReport"] = () => new LeaveDepartmentReport(),
            //["LeaveEmployeeReport"] =()=> new LeaveEmployeeReport(),
            //["LeaveSummaryReport"] =()=> new LeaveSummaryReport (),
            //["NoteCategoryReport"] =()=> new NoteCategoryReport(),
            //["NotesEmployeeReport"] =()=> new NotesEmployeeReport(),
            //["NotesSummaryReport"] =()=> new NotesSummaryReport(),
            //["AppraisalPerformanceByAppraisalTypeReport"] =()=> new AppraisalPerformanceByAppraisalTypeReport(),
            //["AppraisalPerformanceByEmployeeReport"] = () => new AppraisalPerformanceByEmployeeReport(),
            //["CompensationBenefitByDepartmentReport"] = () => new CompensationBenefitByDepartmentReport(),
            //["CompensationBenefitByJobTitleReport"] = () => new CompensationBenefitByJobTitleReport(),
            //["CompensationBenefitByEmployeeReport"] =()=> new CompensationBenefitByEmployeeReport(),
            //["MedicalEmployeeReport"] = () => new MedicalEmployeeReport(),
            //["MedicalSummaryReport"] = () => new MedicalSummaryReport(),
            //["MedicalTypeReport"] = () => new MedicalTypeReport(),
            //["RecruitmentSelectionReferenceReport"] = () => new RecruitmentSelectionReferenceReport(),
            //["RecruitmentSelectJobTitleReport"] = () => new RecruitmentSelectJobTitleReport(),
            //["TrainingDevelopmentByReferenceReport"] = () => new TrainingDevelopmentByReferenceReport(),
            //["TrainingDevelopmentBySummaryReport"] = () => new TrainingDevelopmentBySummaryReport(),
            //["TrainingDevelopmentByTrainingTypeReport"] = () => new TrainingDevelopmentByTrainingTypeReport(),
            //["EmployeeByGenderReport"] =()=>new EmployeeByGenderReport(),
            //["AgeDetailByYearReport"] =()=>new AgeDetailByYearReport(),
            //["Daily_HME_KPIReport"]=()=> new Daily_HME_KPIReport(),
            //["DailyPMComplianceReport"]=()=> new DailyPMComplianceReport(),
            //["MemberListReport"]=()=> new MemberListReport(),
            //["NumberOfCarperManufacturerReport"] = () => new NumberOfCarperManufacturerReport(),
            //["ProductionStatisticsReport"]=()=> new ProductionStatisticsReport(),
            //["WarrantyEndOfLifeReport"]=()=> new WarrantyEndOfLifeReport(),
            //["ServiceTypeReport"]=()=> new ServiceTypeReport(),
            //["AppraisalSummaryReport"]=()=> new AppraisalSummaryReport(),
            //["AllEquipmentSummary"] =()=> new AllEquipmentSummary(),
            //["Changeoutbyrefilltypemodel"] =()=> new Changeoutbyrefilltypemodel(),
            //["ChangeoutByModel"] = () => new ChangeoutByModel(),
            //["FaultByCustodianDetail"] =()=>new FaultByCustodianDetail(),
            //["FaultByCustodianSummary"] =()=>new FaultByCustodianSummary(),
            //["FaultByModelSummary"] =()=>new FaultByModelSummary(),
            //["ListEquipmentSummary"] =()=>new ListEquipmentSummary(),
            //["meteringbymodelclasssummary"] =()=>new meteringbymodelclasssummary(),
            //["MeteringbyModelDetail"] =()=>new MeteringbyModelDetail(),
            //["Meteringbymodelsummary"] =()=>new Meteringbymodelsummary(),
            //["FaultByDowntimeReport"] =()=>new FaultByDowntimeReport(),
            //["ScheduleByLocationSummaryReport"] =()=>new ScheduleByLocationSummaryReport(),
            //["ScheduleByModelSummaryReport"] =()=>new ScheduleByModelSummaryReport(),
            //["ScheduleByServiceTypeReport"] =()=>new ScheduleByServiceTypeReport(),
            //["MeteringByEquipment"] =()=>new MeteringByEquipment(),
            //["EquipmentTransactionReport"] =()=>new EquipmentTransactionReport(),
            //["HoursReport"] =()=>new HoursReport(),
            //["Scheduletransaction"] =()=>new Scheduletransaction(),
            //["ChangeoutReport"] =()=>new ChangeoutReport(),

        };
    }
}