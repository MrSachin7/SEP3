package group6.semester.project.services.SericeImpl;

import group6.semester.project.grpcClient.Report.ReportClient;
import group6.semester.project.model.Bookmark;
import group6.semester.project.model.Post;
import group6.semester.project.model.Report;
import group6.semester.project.services.BookmarkService;
import group6.semester.project.services.ReportService;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ReportServiceImpl implements ReportService
{

  private final ReportClient reportClient;

  public ReportServiceImpl(ReportClient reportClient)
  {
    this.reportClient = reportClient;
  }

  @Override public void AddReport(Report report)
  {
    try
    {
      reportClient.AddReport(report);
    }
    catch (Exception e)
    {
      e.printStackTrace();
    }
  }

  @Override public void RemoveReport(Report report)
  {

  }

  @Override public List<Report> getReports()
  {
    return null;
  }
}
