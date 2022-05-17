package group6.semester.project.grpcClient.Report;

import GRPCService.ReportGrpc;
import GRPCService.ReportOuterClass;
import group6.semester.project.grpcClient.ConvertGrpc;
import group6.semester.project.grpcClient.ManagedChannelGetter;
import group6.semester.project.model.Report;
import io.grpc.ManagedChannel;
import org.springframework.stereotype.Service;

import java.lang.constant.Constable;
import java.security.cert.Extension;
import java.util.List;
@Service

public class ReportGRPCClientImpl implements ReportClient {

    private ReportGrpc.ReportBlockingStub reportBlockingStub;

    private ReportGrpc.ReportBlockingStub getReportBlockingStub(){
        if (reportBlockingStub == null){
            ManagedChannel managedChannel = ManagedChannelGetter.getManagedChannel();
            reportBlockingStub = ReportGrpc.newBlockingStub(managedChannel);
        }
        return  reportBlockingStub;
    }

    @Override
    public void AddReport(Report report) throws Exception
    {
        try
        {
            ReportOuterClass.ReportObj reportObjToSend = ConvertGrpc.getGrpcReportFromOurReport(report);
            getReportBlockingStub().addReport(reportObjToSend);
            disposeStub();
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
            throw new Exception("Could not add report");
        }
    }

    @Override
    public void RemoveReport(Report report) {

        try {
            ReportOuterClass.ReportObj obj =ConvertGrpc.getGrpcReportFromReport(report);
            ReportOuterClass.EmptyReportMark message = null;
        }
        catch (Exception e){
            throw  new RuntimeException(e);
        }
        finally {
            disposeStub();
        }

    }

    @Override
    public List<Report> getReports() {
        try {
            ReportOuterClass.EmptyReportMark message = null;
            ReportOuterClass.ListOfReports obj = getReportBlockingStub().getReports(message);
            return ConvertGrpc.getListOfReporstFromListOfGrpcReportObject(obj.getReportObjList());
        }catch (Exception e)
        {
            throw new RuntimeException(e);
        }finally {
            disposeStub();
        }
    }

    private void disposeStub(){
        reportBlockingStub = null;
    }






}
