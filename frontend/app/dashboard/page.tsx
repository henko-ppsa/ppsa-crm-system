'use client';

import { useEffect, useState } from 'react';
import api from '@/lib/api';

interface DashboardSummary {
  totalCustomers: number;
  activeProjects: number;
  openTasks: number;
  overdueTasks: number;
  activitiesToday: number;
  newCustomersThisMonth: number;
}

export default function DashboardPage() {
  const [summary, setSummary] = useState<DashboardSummary | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchDashboard = async () => {
      try {
        const response = await api.get<DashboardSummary>('/dashboard/summary');
        setSummary(response.data);
      } catch (error) {
        console.error('Error fetching dashboard:', error);
      } finally {
        setLoading(false);
      }
    };

    fetchDashboard();
  }, []);

  if (loading) {
    return (
      <div className="flex justify-center items-center h-64">
        <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600"></div>
      </div>
    );
  }

  const stats = [
    { name: 'Total Customers', value: summary?.totalCustomers || 0, color: 'bg-blue-500' },
    { name: 'Active Projects', value: summary?.activeProjects || 0, color: 'bg-green-500' },
    { name: 'Open Tasks', value: summary?.openTasks || 0, color: 'bg-yellow-500' },
    { name: 'Overdue Tasks', value: summary?.overdueTasks || 0, color: 'bg-red-500' },
    { name: 'Activities Today', value: summary?.activitiesToday || 0, color: 'bg-purple-500' },
    { name: 'New This Month', value: summary?.newCustomersThisMonth || 0, color: 'bg-indigo-500' },
  ];

  return (
    <div className="px-4 py-6 sm:px-0">
      <h1 className="text-2xl font-semibold text-gray-900 mb-6">Dashboard</h1>
      
      <div className="grid grid-cols-1 gap-5 sm:grid-cols-2 lg:grid-cols-3">
        {stats.map((stat) => (
          <div
            key={stat.name}
            className="bg-white overflow-hidden shadow rounded-lg"
          >
            <div className="p-5">
              <div className="flex items-center">
                <div className={`flex-shrink-0 ${stat.color} rounded-md p-3`}>
                  <span className="text-white text-2xl font-bold">
                    {stat.value}
                  </span>
                </div>
                <div className="ml-5 w-0 flex-1">
                  <dt className="text-sm font-medium text-gray-500 truncate">
                    {stat.name}
                  </dt>
                </div>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}